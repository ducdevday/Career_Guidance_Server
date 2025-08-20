using CareerGuidance.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Workshop : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Thumnail { get; set; }
        public int Duration { get; set; }
        public TimeType TimeType { get; set; }
        public double? RatingStar { get; set; }
        public int? RatingCount { get; set; }
        public TourStatusType Status { get; set; }
        public string? FullAddress { get; set; }
        public string? StreetName { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        public int WardId { get; set; }
        public Ward Ward { get; set; }
        public int IndustryId { get; set; }
        public Industry Industry { get; set; }
        public List<UserEnrollWorkshop> UserEnrollWorkshops { get; set; }
        public List<WorkshopReview> WorkshopReviews { get; set; }
    }
}
