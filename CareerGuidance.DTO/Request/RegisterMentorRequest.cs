using CareerGuidance.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DTO.Request
{
    public class RegisterMentorRequest
    {
        public string Description { get; set; }
        public string Position { get; set; }
        public int YOE { get; set; }
        public int IndustryId { get; set; }
    }
}
