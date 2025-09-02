using EducationChallengerBE.Shared.Dtos;
using System.Net;

namespace CareerGuidance.DTO.Response
{
    public class CreateIndustryResponse : BaseApiResponse<bool>
    {
        public CreateIndustryResponse(HttpStatusCode statusCode, List<string> messages, bool data) : base(statusCode, messages, data)
        {
        }
    }
    
}
