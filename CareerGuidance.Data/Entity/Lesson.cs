using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Lesson : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public string ThumnalUrl { get; set; }


        public int ChapterId { get; set; }
        public Chapter Chapter { get; set; }
        public List<Resource> Resources { get; set; }
    }
}
