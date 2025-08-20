using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class School : AuditableEntity
    {
        public Guid Id { get; set; } 
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public string? Avatar { get; set; }
        public string? Description { get; set; }
        public string? FullAddress { get; set; }
        public string? StreetName { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        public int WardId { get; set; }
        public Ward Ward { get; set; }
        public User User { get; set; }
    }
}
