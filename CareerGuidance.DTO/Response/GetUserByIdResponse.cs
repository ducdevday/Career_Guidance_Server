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
    public class GetUserByIdResponse : BaseApiResponse<UserDto?>
    {
        public GetUserByIdResponse(HttpStatusCode statusCode, List<string> messages, UserDto? data) : base(statusCode, messages, data)
        {
        }
    }
}
