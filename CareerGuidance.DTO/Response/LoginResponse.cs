using CareerGuidance.DTO.Dtos.Nested;
using EducationChallengerBE.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DTO.Response
{
    public class LoginResponse : BaseApiResponse<LoginNested?>
    {
        public LoginResponse(HttpStatusCode statusCode, List<string> messages, LoginNested? data) : base(statusCode, messages, data)
        {
        }
    }
}
