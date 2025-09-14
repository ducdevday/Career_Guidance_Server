using CareerGuidance.DataAccess;
using CareerGuidance.DTO.Request;
using CareerGuidance.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.BussinessLogic.Interface
{
    public interface IAuthBusiness
    {
        public Task<SignUpResponse> SignUpAsync(SignUpRequest request);
        public Task<LoginResponse> LoginAsync(LoginRequest request);
        public Task<VerifyEmailSignUpResponse> VetifyEmailSignUpAsync(VerifyEmailSignUpRequest request);
        public Task<ForgotPasswordResponse> ForgotPasswordAsync(ForgotPasswordRequest forgotPasswordRequest);
        public Task<SetNewPasswordResponse> SetNewPasswordAsync(SetNewPasswordRequest setNewPasswordRequest);
        public Task<RefreshTokenResponse> RefreshTokenAsync();
        public Task<LogoutResponse> LogoutAsync();
        public Task<RegisterMentorResponse> RegisterMentorAsync(RegisterMentorRequest request);

    }
}
