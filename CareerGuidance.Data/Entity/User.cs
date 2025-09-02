using CareerGuidance.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class User : AuditableEntity
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? MiddleName { get; set; }
        public GenderType Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Password { get; set; }
        public RoleType Role { get; set; }
        public AccountStatusType Status {get; set;}
        public string? Avatar { get; set; }
        
        public Mentor? Mentor { get; set; }
        public List<UserEnrollCourse> UserEnrollCourses { get; set; }
        public List<UserEnrollWorkshop> UserEnrollWorkshops { get; set; }
        public List<Notification> Notifications { get; set; }
    }
}
