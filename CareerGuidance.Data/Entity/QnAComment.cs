using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class QnAComment : AuditableEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int? Ups { get; set; }
        public int? Downs { get; set; }

        public int QnAPostId { get; set; }
        public QnAPost QnAPost { get; set; }
        public List<QnACommentInteraction> QnACommentInteractions { get; set; }
    }
}
