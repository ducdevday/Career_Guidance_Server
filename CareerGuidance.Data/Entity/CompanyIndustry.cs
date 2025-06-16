using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class CompanyIndustry: AuditableEntity
    {
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public int IndustryId { get; set; }
        public Industry Industry { get; set; }
    }
}
