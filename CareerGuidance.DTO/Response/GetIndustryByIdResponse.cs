using EducationChallengerBE.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CareerGuidance.DTO.Dtos.Nested;

namespace CareerGuidance.DTO.Response
{
    public class GetIndustryByIdResponse : BaseApiResponse<IndustryDto?>
    {
        public GetIndustryByIdResponse(HttpStatusCode statusCode, List<string> messages, IndustryDto? data) : base(statusCode, messages, data)
        {
        }
    }
}
