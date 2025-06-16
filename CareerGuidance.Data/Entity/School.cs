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
        public DateTime EstablishmentDate { get; set; }
        public string? Avatar { get; set; }
        public string? Bio { get; set; }
        public string? About { get; set; }
        public string? Website { get; set; }
        public string? FacebookUrl { get; set; }
        public string? TiktokUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? LinkedinUrl { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public List<SchoolIndustry> SchoolIndustries { get; set; }
    }
}
