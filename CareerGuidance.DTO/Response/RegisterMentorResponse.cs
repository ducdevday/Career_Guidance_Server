using EducationChallengerBE.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DTO.Response
{
    public class RegisterMentorResponse : BaseApiResponse<string>
    {
        public RegisterMentorResponse(HttpStatusCode statusCode, List<string> messages, string data) : base(statusCode, messages, data)
        {

        }
    }
}
