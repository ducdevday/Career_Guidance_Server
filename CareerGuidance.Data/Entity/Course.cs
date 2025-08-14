using CareerGuidance.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Course : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string VideoAdsUrl { get; set; }
        public string ThumnalUrl { get; set; }
        public int Order { get; set; }
        public double? RatingStar { get; set; }
        public int? RatingCount { get; set; }
        public CourseStatusType Status { get; set; }


        public int IndustryId { get; set; }
        public Industry Industry { get; set; }
        public List<UserEnrollCourse> UserEnrollCourses { get; set; }
        public List<Chapter> Chapters { get; set; }
    }
}
