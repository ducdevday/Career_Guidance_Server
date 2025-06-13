using CareerGuidance.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public abstract class User : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Password { get; set; }
        public RoleType Role { get; set; }
        public AccountStatusType Status {get; set;}
        public string? Avatar { get; set; }
        public string? Bio { get; set; }
        public string? About { get; set; }
        public string? Website { get; set; }
        public string? FacebookUrl { get; set; }
        public string? TiktokUrl { get; set; }
        public string? InstagramUrl { get; set; }
        public string? LinkedinUrl { get; set; }
        public int? AddressId { get; set; }
        public Address? Address { get; set; }

        public List<UserIndustry> UserIndustries { get; set; }
        public List<UserEnrollCourse> UserEnrollCourses { get; set; }
        public List<UserEnrollTour> UserEnrollTours { get; set; }
        public List<UserEnrollWorkshop> UserEnrollWorkshops { get; set; }
    }
}
