using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Mentor : AuditableEntity
    {
        public Guid Id { get; set; }
        public string? Avatar { get; set; } 
        public string Description { get; set; }
        public string Position { get; set; }
        public int YOE { get; set; } 
        public int IndustryId { get; set; }
        public Industry Industry { get; set; }
        public User User { get; set; }
    }
}
