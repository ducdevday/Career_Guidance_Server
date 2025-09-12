using EducationChallengerBE.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DTO.Request
{
    public class SearchUserRequest : BaseApiRequest
    {
        public string? Keyword { get; set; }
        public string? SortBy { get; set; }
        public bool IsDescending { get; set; }
    }
}
