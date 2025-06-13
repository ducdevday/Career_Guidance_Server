using CareerGuidance.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Blog : AuditableEntity
    {
        public int Id { get; set; }
        public string ThumnailUrl { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int TimeForReadValue { get; set; }
        public TimeType TimeForReadType { get; set; }
        public BlogStatusType Status { get; set; }


        public int IndustryId { get; set; }
        public Industry Industry { get; set; }
        public List<BlogComment> BlogComments { get; set; }
    }
}
