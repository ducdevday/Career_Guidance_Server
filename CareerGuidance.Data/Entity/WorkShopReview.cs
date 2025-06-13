using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class WorkShopReview : AuditableEntity
    {
        public Guid Id { get; set; }
        public int Rating { get; set; }
        public string Content { get; set; }

        public int WorkShopId { get; set; }
        public Workshop Workshop { get; set; }
    }
}
