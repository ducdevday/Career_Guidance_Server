using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public abstract class AuditableEntity
    {
        public bool Active { get; set; } 
        public DateTime InsertDate { get; set; }
        public Guid InsertById { get; set; }
        public User InsertBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid UpdatedById { get; set; }
        public User UpdatedBy { get; set; }

    }
}
