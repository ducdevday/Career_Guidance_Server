using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DTO.Request
{
    public class VerifyEmailSignUpRequest
    {
        public string Email { get; set; }
        public string Code { get; set; }
    }
}
