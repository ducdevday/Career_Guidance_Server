using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class TourReview : AuditableEntity
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Content { get; set; }

        public int TourId { get; set; }
        public Tour Tour { get; set; }
    }
}
