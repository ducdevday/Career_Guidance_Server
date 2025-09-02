using EducationChallengerBE.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DTO.Response
{
    public class UpdateIndustryResponse : BaseApiResponse<bool>
    {
        public UpdateIndustryResponse(HttpStatusCode statusCode, List<string> messages, bool data) : base(statusCode, messages, data)
        {
        }
    }
}
