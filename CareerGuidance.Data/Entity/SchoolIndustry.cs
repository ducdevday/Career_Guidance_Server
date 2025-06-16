using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class SchoolIndustry : AuditableEntity
    {
        public Guid SchoolId { get; set; }
        public School School { get; set; }
        public int IndustryId { get; set; }
        public Industry Industry { get; set; }
    }
}
