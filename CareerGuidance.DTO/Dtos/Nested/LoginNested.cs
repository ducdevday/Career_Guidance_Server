using CareerGuidance.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DTO.Dtos.Nested
{
    public class LoginNested
    {
        public Guid UserId { get; set; }
        public string FullName { get; set; }
        public RoleType Role { get; set; }

    }
}
