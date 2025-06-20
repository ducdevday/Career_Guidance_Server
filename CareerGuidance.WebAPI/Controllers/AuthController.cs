using CareerGuidance.BussinessLogic.Interface;
using CareerGuidance.DTO.Request;
using CareerGuidance.Shared.Constant;
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

        [HttpPost("/SignUp")]
        public async Task<IActionResult> SignUp([FromBody] SignUpRequest signUpRequest) { 
            var result = await _authBusiness.SignUpAsync(signUpRequest);
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }
        [HttpPost("/LogIn")]
        public async Task<IActionResult> LogIn([FromBody] LoginRequest loginInRequest)
        {
            var result = await _authBusiness.LoginAsync(loginInRequest);
            HttpContext.Response.StatusCode = (int)result.StatusCode;
            return new JsonResult(result);
        }
    }
}
