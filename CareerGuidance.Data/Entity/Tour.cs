using CareerGuidance.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Tour : AuditableEntity
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

        public int IndustryId { get; set; }
        public Industry Industry { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public List<UserEnrollTour> UserEnrollTours { get; set; }
        public List<TourReview> TourReviews { get; set; }
    }
}
