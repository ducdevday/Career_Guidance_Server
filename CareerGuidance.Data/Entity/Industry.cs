using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Industry : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public List<Mentor> Mentors { get; set; } 
        public List<Course> Courses { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Workshop> Workshops { get; set; }
    }
}
