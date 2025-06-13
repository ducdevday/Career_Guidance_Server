using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class QnAPost : AuditableEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? Replies { get; set; }
        public int? Ups { get; set; }
        public int? Downs { get; set; }

        public List<QnAComment> QnAComments { get; set; }
        public List<QnAPostInteraction> QnAPostInteractions { get; set; }
    }
}
