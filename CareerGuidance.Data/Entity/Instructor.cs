using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Instructor : AuditableEntity
    {
        public Guid Id { get; set; }
        public string Avatar { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Bio { get; set; }
        
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
