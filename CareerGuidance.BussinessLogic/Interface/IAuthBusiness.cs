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
        public Task<SignUpResponse> SignUpAsync(SignUpRequest signUpRequest);
        public Task<LoginResponse> LoginAsync(LoginRequest loginRequest);
    }
}
