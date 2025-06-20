using AutoMapper;
using CareerGuidance.BussinessLogic.Interface;
using CareerGuidance.Data.Entity;
using CareerGuidance.Data.Enum;
using CareerGuidance.DataAccess;
using CareerGuidance.DTO.Dtos.Nested;
using CareerGuidance.DTO.Request;
using CareerGuidance.DTO.Response;
using CareerGuidance.Setting;
using CareerGuidance.Shared.Constant;
using CareerGuidance.Shared.Util;
using FluentValidation;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Runtime;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.BussinessLogic.Business
{
    public class AuthBusiness : IAuthBusiness
    {
        private readonly IDataAccessFacade _context;
        private readonly IMapper _mapper;
        private readonly IValidator<SignUpRequest> _signUpValidator;
        private readonly IValidator<LoginRequest> _loginValidator;

        public AuthBusiness(IDataAccessFacade context, IMapper mapper, IValidator<SignUpRequest> signUpValidator, IValidator<LoginRequest> loginValidator)
        {
            _context = context;
            _mapper = mapper;
            _signUpValidator = signUpValidator;
            _loginValidator = loginValidator;
        }

        public async Task<SignUpResponse> SignUpAsync(SignUpRequest signUpRequest)
        {
            var validation = await _signUpValidator.ValidateAsync(signUpRequest);

            if (!validation.IsValid)
            {
                return new SignUpResponse(HttpStatusCode.BadRequest,
                    validation.Errors.Select(e => e.ErrorMessage).ToList(), false);
            }

            var isExistedUser = await _context.UserData.IsExistedUserAsync(signUpRequest.Email, signUpRequest.PhoneNumber);

            if (isExistedUser)
            {
                return new SignUpResponse(HttpStatusCode.BadRequest, new List<string> { "Email already exists" }, false);
            }

            User user = _mapper.Map<User>(signUpRequest);

            var createdUser = await _context.UserData.SignUpAccountAsync(user);
            if (createdUser == null)
            {
                return new SignUpResponse(HttpStatusCode.InternalServerError, new List<string> { "Failed to create user" }, false);
            }
            await _context.Commit();

            return new SignUpResponse(HttpStatusCode.OK, new List<string> { "User signed up successfully" }, true);
        }

        public async Task<LoginResponse> LoginAsync(LoginRequest loginRequest)
        {
            var validation = await _loginValidator.ValidateAsync(loginRequest);
            if (!validation.IsValid)
            {
                return new LoginResponse(HttpStatusCode.BadRequest,
                    validation.Errors.Select(e => e.ErrorMessage).ToList(), null);
            }

            var user = await _context.UserData.GetUserByEmailAsync(loginRequest.Email);
            if (user == null)
            {
                return new LoginResponse(HttpStatusCode.BadRequest, new List<string> { "User does not exist" }, null);
            }

            if (!PasswordUtil.ValidatePassword(loginRequest.Password, user.Password))
            {
                return new LoginResponse(HttpStatusCode.BadRequest, new List<string> { "Incorrect password" }, null);
            }

            var accessToken = GenerateAccessToken(user.Id, user.Role);
            var refreshToken = GenerateRefreshToken();

            return new LoginResponse(HttpStatusCode.OK, new List<string> { "Login successful" }, new LoginNested
            {
                AccessToken = accessToken,
                RefreshToken = refreshToken,
                UserId = user.Id,
                FullName = $"{user.LastName}{(string.IsNullOrWhiteSpace(user.MiddleName) ? "" : " " + user.MiddleName)} {user.FirstName}",
                Role = user.Role
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

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(TimeConstant.AccessTokenExpiryMinutes),
                Issuer = EnviromentSetting.Instance.Issuer,
                Audience = EnviromentSetting.Instance.Audience,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            return new JwtSecurityTokenHandler().WriteToken(
                new JwtSecurityTokenHandler().CreateToken(tokenDescriptor));
        }

        public string GenerateRefreshToken()
        {
            return Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
        }


    }
}
