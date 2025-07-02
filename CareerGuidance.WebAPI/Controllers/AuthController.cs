using CareerGuidance.BussinessLogic.Interface;
using CareerGuidance.DTO.Request;
using CareerGuidance.Shared.Constant;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CareerGuidance.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthBusiness _authBusiness;
        public AuthController(IAuthBusiness authBusiness)
        {
            _authBusiness = authBusiness;
        }

        [HttpPost("Signup")]
        public async Task<IActionResult> SignUp([FromBody] SignUpRequest signUpRequest) { 
            var result = await _authBusiness.SignUpAsync(signUpRequest);
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginInRequest)
        {
            var result = await _authBusiness.LoginAsync(loginInRequest);
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }

        [HttpPost("RefreshToken")]
        public async Task<IActionResult> RefreshToken()
        {
            var result = await _authBusiness.RefreshTokenAsync();
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }

        [HttpPost("Logout")]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            var result = await _authBusiness.LogoutAsync();
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }

        [HttpPost("VerifyEmailSignUp")]
        public async Task<IActionResult> VerifyEmailSignUp([FromBody] VerifyEmailSignUpRequest vetifyEmailSignUpRequest)
        {
            var result = await _authBusiness.VetifyEmailSignUpAsync(vetifyEmailSignUpRequest);
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }

        [HttpPost("ForgotPassword")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordRequest forgotPasswordRequest)
        {
            var result = await _authBusiness.ForgotPasswordAsync(forgotPasswordRequest);
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }

        [HttpPost("SetNewPassword")]
        public async Task<IActionResult> SetNewPassword([FromBody] SetNewPasswordRequest setNewPasswordRequest)
        { 
            var result = await _authBusiness.SetNewPasswordAsync(setNewPasswordRequest);
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }
    }
}
