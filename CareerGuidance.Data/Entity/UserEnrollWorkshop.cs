using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class UserEnrollWorkshop : AuditableEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public int WorkshopId { get; set; }
        public Workshop Workshop { get; set; }
    }
}
