using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class UserIndustry: AuditableEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public int IndustryId { get; set; }
        public Industry Industry { get; set; }
    }
}
