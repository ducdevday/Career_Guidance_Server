using CareerGuidance.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Resource : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SourceUrl { get; set; }
        public SourceType SourceType { get; set; }


        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
