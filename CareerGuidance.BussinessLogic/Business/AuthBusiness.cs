using AutoMapper;
using CareerGuidance.BussinessLogic.Interface;
using CareerGuidance.Data.Entity;
using CareerGuidance.Data.Enum;
using CareerGuidance.DataAccess;
using CareerGuidance.DTO.Dtos.Nested;
using CareerGuidance.DTO.Request;
using CareerGuidance.DTO.Response;
using CareerGuidance.Email.Factory;
using CareerGuidance.Email.Templates;
using CareerGuidance.Setting;
using CareerGuidance.Shared.Constant;
using CareerGuidance.Shared.Util;
using CareerGuidance.Validation.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace CareerGuidance.BussinessLogic.Business
{
    public class AuthBusiness : BaseBusiness, IAuthBusiness
    {
        public AuthBusiness(IDataAccessFacade context, IMapper mapper, IValidationService validation, IHttpContextAccessor httpContextAccessor) : base(context, mapper, validation, httpContextAccessor)
        {
        }

        public async Task<SignUpResponse> SignUpAsync(SignUpRequest signUpRequest)
        {
            var validation = await _validation.ValidateAsync(signUpRequest);

            if (!validation.IsValid)
            {
                return new SignUpResponse(HttpStatusCode.BadRequest,
                    validation.Errors.Select(e => e.ErrorMessage).ToList(), string.Empty);
            }

            var isExistedUser = await _context.UserData.IsExistAsync(x => x.Email == signUpRequest.Email || x.PhoneNumber == signUpRequest.PhoneNumber);

            if (isExistedUser)
            {
                return new SignUpResponse(HttpStatusCode.BadRequest, new List<string> { "Email already exists" }, string.Empty);
            }

            User user = _mapper.Map<User>(signUpRequest);

            var createdUser = await _context.UserData.SignUpAccountAsync(user);
            if (createdUser == null)
            {
                return new SignUpResponse(HttpStatusCode.InternalServerError, new List<string> { "Failed to create user" }, string.Empty);
            }

            EmailVerification emailVerification = _mapper.Map<EmailVerification>(user);
            emailVerification.Type = EmailVerificationType.SignUp;

            var addedemailVerification = await _context.EmailVerificationData.AddEmailVerificationAsync(emailVerification);
            if (addedemailVerification == null)
            {
                return new SignUpResponse(HttpStatusCode.InternalServerError, new List<string> { "Failed to create email verification" }, string.Empty);
            }

            await _context.CommitAsync();


            var factory = new MessageDeliveryFactory();
            var deliveryMethods = factory.Create(NotificationType.Email);
            deliveryMethods.SetMode(MessageDeliveryMode.Template)
                            .SetUser(createdUser)
                            .SetSender(EnviromentSetting.Instance.SmtpEmail)
                            .SetRecipient(createdUser.Email)
                            .SetDisplayName(NotificationConstant.COMPANY_FULLNAME)
                            .SetExternalFields(new List<ExternalField>() {
                                new ExternalField(){
                                    Name = "VerificationCode",
                                    Value = emailVerification.Token,
                                    IsBody = true
                                },
                                new ExternalField(){
                                    Name = "ExpiredAt",
                                    Value = TimeConstant.EmailVerificationTokenExpiruMinutes.ToString(),
                                    IsBody = true
                                }
                                })
                            .SetTemplate(TemplateSample.AccountSignUpTemplate);

            await deliveryMethods.Send();

            return new SignUpResponse(HttpStatusCode.OK, new List<string> { "User signed up successfully" }, signUpRequest.Email);
        }

        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            var validation = await _validation.ValidateAsync(loginRequest);
            if (!validation.IsValid)
            {
                return new LoginResponse(HttpStatusCode.BadRequest,
                    validation.Errors.Select(e => e.ErrorMessage).ToList(), null);
            }

            var user = await _context.UserData.GetAsync(x => x.Email == loginRequest.Email);
            if (user == null)
            {
                return new LoginResponse(HttpStatusCode.BadRequest, new List<string> { "User does not exist" }, null);
            }

            if (!SecretUtil.ValidatePassword(loginRequest.Password, user.Password))
            {
                return new LoginResponse(HttpStatusCode.BadRequest, new List<string> { "Incorrect password" }, null);
            }

            if (user.Status == AccountStatusType.Unverified)
            {
                return new LoginResponse(HttpStatusCode.Forbidden, new List<string> { "Account is not verified" }, null);
            }

            var accessToken = GenerateAccessToken(user.Id, user.Role);
            var refreshToken = GenerateRefreshToken();

            var refreshTokenEntity = _mapper.Map<RefreshToken>(refreshToken);
            await _context.RefreshTokenData.AddRefreshTokenAsync(refreshTokenEntity);

            ResponseCookies.Append(CookieConstant.REFRESH_TOKEN, refreshToken, new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None,
                Expires = DateTime.UtcNow.AddDays(TimeConstant.RefreshTokenExpiryDays)
            });

            await _context.CommitAsync();

            return new LoginResponse(HttpStatusCode.OK, new List<string> { "Login successful" }, new LoginNested
            {
                UserId = user.Id,
                FullName = $"{user.LastName}{(string.IsNullOrWhiteSpace(user.MiddleName) ? "" : " " + user.MiddleName)} {user.FirstName}",
                Role = user.Role,
                AccessToken = accessToken
            });
        }

        private string GenerateAccessToken(Guid userId, RoleType role)
        {
            var key = Encoding.ASCII.GetBytes(EnviromentSetting.Instance.SecretKey);

            var claims = new[]
            {
                 new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
                 new Claim(ClaimTypes.Role, role.ToString())
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(TimeConstant.AccessTokenExpiryMinutes),
                Issuer = EnviromentSetting.Instance.Issuer,
                Audience = EnviromentSetting.Instance.Audience,
                SigningCredentials =
                    new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public string GenerateRefreshToken()
        {
            return Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
        }


        public async Task<VerifyEmailSignUpResponse> VetifyEmailSignUpAsync(VerifyEmailSignUpRequest request)
        {
            var validation = await _validation.ValidateAsync(request);
            if (!validation.IsValid)
            {
                return new VerifyEmailSignUpResponse(HttpStatusCode.BadRequest,
                    validation.Errors.Select(e => e.ErrorMessage).ToList(), false);
            }
            var user = await _context.UserData.GetAsync(x => x.Email == request.Email);
            if (user == null)
            {
                return new VerifyEmailSignUpResponse(HttpStatusCode.NotFound, new List<string> { "Email does not exist" }, false);
            }
            if (user.Status == AccountStatusType.Verified)
            {
                return new VerifyEmailSignUpResponse(HttpStatusCode.Conflict, new List<string> { "Email is already verified" }, false);
            }

            var emailVerification = await _context.EmailVerificationData.GetEmailVerificationByUserIdAsync(user.Id, EmailVerificationType.SignUp);
            if (emailVerification == null)
            {
                return new VerifyEmailSignUpResponse(HttpStatusCode.NotFound, new List<string> { "Email verification not found" }, false);
            }

            if (emailVerification.Token != request.Code)
            {
                return new VerifyEmailSignUpResponse(HttpStatusCode.BadRequest, new List<string> { "Invalid verification code" }, false);
            }

            if (emailVerification.ExpiresAt < DateTime.UtcNow)
            {
                return new VerifyEmailSignUpResponse(HttpStatusCode.Gone, new List<string> { "Verification code has expired" }, false);
            }

            if (emailVerification.IsUsed)
            {
                return new VerifyEmailSignUpResponse(HttpStatusCode.Conflict, new List<string> { "Verification code has already been used" }, false);
            }

            user.Status = AccountStatusType.Verified;
            emailVerification.IsUsed = true;

            await _context.CommitAsync();

            return new VerifyEmailSignUpResponse(HttpStatusCode.OK, new List<string> { "Email verified successfully" }, true);
        }
        public async Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest request)
        {
            var validation = await _validation.ValidateAsync(request);
            if (!validation.IsValid)
            {
                return new ForgotPasswordResponse(HttpStatusCode.BadRequest,
                    validation.Errors.Select(e => e.ErrorMessage).ToList(), false);
            }
            var user = await _context.UserData.GetAsync(x => x.Email == request.Email);
            if (user == null)
            {
                return new ForgotPasswordResponse(HttpStatusCode.NotFound, new List<string> { "Email does not exist" }, false);
            }

            if (user.Status == AccountStatusType.Unverified)
            {
                return new ForgotPasswordResponse(HttpStatusCode.Forbidden, new List<string> { "Email is not verified" }, false);
            }

            var emailVerification = _mapper.Map<EmailVerification>(user);
            emailVerification.Type = EmailVerificationType.ForgotPassword;

            var addedemailVerification = await _context.EmailVerificationData.AddEmailVerificationAsync(emailVerification);
            if (addedemailVerification == null)
            {
                return new ForgotPasswordResponse(HttpStatusCode.InternalServerError, new List<string> { "Failed to create email verification" }, false);
            }
            await _context.CommitAsync();

            var factory = new MessageDeliveryFactory();
            var deliveryMethods = factory.Create(NotificationType.Email);
            deliveryMethods.SetMode(MessageDeliveryMode.Template)
                            .SetUser(user)
                            .SetSender(EnviromentSetting.Instance.SmtpEmail)
                            .SetRecipient(user.Email)
                            .SetDisplayName(NotificationConstant.COMPANY_FULLNAME)
                            .SetExternalFields(new List<ExternalField>() {
                                new ExternalField(){
                                    Name = "VerificationCode",
                                    Value = emailVerification.Token,
                                    IsBody = true
                                },
                                new ExternalField(){
                                    Name = "ExpiredAt",
                                    Value = TimeConstant.EmailVerificationTokenExpiruMinutes.ToString(),
                                    IsBody = true
                                }
                                })
                            .SetTemplate(TemplateSample.ForgotPasswordTemplate);

            await deliveryMethods.Send();

            return new ForgotPasswordResponse(HttpStatusCode.OK, new List<string> { "Forgot password request processed successfully" }, true);
        }

        public async Task<SetNewPasswordResponse> SetNewPasswordAsync(SetNewPasswordRequest setNewPasswordRequest)
        {
            var validation = await _validation.ValidateAsync(setNewPasswordRequest);
            if (!validation.IsValid)
            {
                return new SetNewPasswordResponse(HttpStatusCode.BadRequest,
                    validation.Errors.Select(e => e.ErrorMessage).ToList(), false);
            }

            var user = await _context.UserData.GetAsync(x => x.Email == setNewPasswordRequest.Email);
            if (user == null)
            {
                return new SetNewPasswordResponse(HttpStatusCode.NotFound, new List<string> { "Email does not exist" }, false);
            }

            var emailVerification = await _context.EmailVerificationData.GetEmailVerificationByUserIdAsync(user.Id, EmailVerificationType.ForgotPassword);
            if (emailVerification == null)
            {
                return new SetNewPasswordResponse(HttpStatusCode.NotFound, new List<string> { "Email verification not found" }, false);
            }

            if (emailVerification.Token != setNewPasswordRequest.Code)
            {
                return new SetNewPasswordResponse(HttpStatusCode.BadRequest, new List<string> { "Invalid verification code" }, false);
            }

            if (emailVerification.ExpiresAt < DateTime.UtcNow)
            {
                return new SetNewPasswordResponse(HttpStatusCode.Gone, new List<string> { "Verification code has expired" }, false);
            }

            if (emailVerification.IsUsed)
            {
                return new SetNewPasswordResponse(HttpStatusCode.Conflict, new List<string> { "Verification code has already been used" }, false);
            }

            user.Password = SecretUtil.HashPassword(setNewPasswordRequest.Password);
            emailVerification.IsUsed = true;

            await _context.CommitAsync();
            return new SetNewPasswordResponse(HttpStatusCode.OK, new List<string> { "Password updated successfully" }, true);
        }

        public async Task<RefreshTokenResponse> RefreshTokenAsync()
        {
            var oldRefreshToken = _httpContext.HttpContext.Request.Cookies[CookieConstant.REFRESH_TOKEN];
            if (string.IsNullOrEmpty(oldRefreshToken))
            {
                return new RefreshTokenResponse(HttpStatusCode.Unauthorized, new List<string> { "Refresh token is required" }, string.Empty);
            }

            var refreshTokenEntity = await _context.RefreshTokenData.GetByTokenAsync(SecretUtil.HashToken(oldRefreshToken));

            if (refreshTokenEntity == null || refreshTokenEntity.IsUsed || refreshTokenEntity.ExpiresAt < DateTime.UtcNow)
            {
                return new RefreshTokenResponse(HttpStatusCode.Unauthorized, new List<string> { "Invalid or expired refresh token" }, string.Empty);
            }

            refreshTokenEntity.IsUsed = true;

            if (CurrentUserId == null || CurrentUserRole == null)
            {
                return new RefreshTokenResponse(HttpStatusCode.Unauthorized, new List<string> { "User is not authenticated" }, string.Empty);
            }

            var newAccessToken = GenerateAccessToken(CurrentUserId.Value, CurrentUserRole.Value);
            var newRefreshToken = GenerateRefreshToken();

            var newRefreshTokenEntity = _mapper.Map<RefreshToken>(oldRefreshToken);
            await _context.RefreshTokenData.AddRefreshTokenAsync(refreshTokenEntity);
            await _context.CommitAsync();

            ResponseCookies.Append(CookieConstant.REFRESH_TOKEN, newRefreshToken, new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict,
                Expires = DateTime.UtcNow.AddDays(TimeConstant.RefreshTokenExpiryDays)
            });

            return new RefreshTokenResponse(HttpStatusCode.OK, new List<string> { "Tokens refreshed successfully" }, newAccessToken);
        }

        public async Task<LogoutResponse> LogoutAsync()
        {
            var refreshToken = RequestCookies[CookieConstant.REFRESH_TOKEN];

            if (!string.IsNullOrEmpty(refreshToken))
            {
                var hashedToken = SecretUtil.HashToken(refreshToken);
                var refreshTokenEntity = await _context.RefreshTokenData.GetByTokenAsync(hashedToken);

                if (refreshTokenEntity != null && !refreshTokenEntity.IsUsed)
                {
                    refreshTokenEntity.IsUsed = true;
                }
            }

            ResponseCookies.Delete(CookieConstant.REFRESH_TOKEN);

            await _context.CommitAsync();

            return new LogoutResponse(HttpStatusCode.OK, new List<string> { "Logout successful" }, true);
        }

        public async Task<RegisterMentorResponse> RegisterMentorAsync(RegisterMentorRequest request)
        {
            var validation = await _validation.ValidateAsync(request);

            if (!validation.IsValid)
            {
                return new RegisterMentorResponse(HttpStatusCode.BadRequest,
                    validation.Errors.Select(e => e.ErrorMessage).ToList(), string.Empty);
            }

            var user = await _context.UserData.GetAsync(x => x.Id == CurrentUserId);
            if (user == null)
                return new RegisterMentorResponse(HttpStatusCode.NotFound, new() { "User not found." }, string.Empty);

            if (CurrentUserRole == RoleType.Mentor)
            {
                return new RegisterMentorResponse(HttpStatusCode.Forbidden, new List<string> { "Account is already register mentor" }, string.Empty);
            }

            _mapper.Map(request, user);

            var accessToken = GenerateAccessToken(user.Id, user.Role);
            var refreshToken = GenerateRefreshToken();

            var refreshTokenEntity = _mapper.Map<RefreshToken>(refreshToken);
            await _context.RefreshTokenData.AddRefreshTokenAsync(refreshTokenEntity);

            ResponseCookies.Append(CookieConstant.REFRESH_TOKEN, refreshToken, new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.None,
                Expires = DateTime.UtcNow.AddDays(TimeConstant.RefreshTokenExpiryDays)
            });

            await _context.CommitAsync();

            return new RegisterMentorResponse(HttpStatusCode.OK, new List<string> { "Register Mentor Success" }, accessToken);


        }

    }
}
