using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class QnACommentInteraction : AuditableEntity
    {
        public Guid Id { get; set; }
        public bool IsUp { get; set; }
        public bool IsDown { get; set; }
        public int QnACommentId { get; set; }
        public QnAComment QnAComment { get; set; }
    }
}
