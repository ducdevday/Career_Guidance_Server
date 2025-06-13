using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class QnAPostInteraction : AuditableEntity
    {
        public Guid Id { get; set; }
        public bool IsUp { get; set; }
        public bool IsDown { get; set; }
        public int QnAPostId { get; set; }
        public QnAPost QnAPost { get; set; }
    }
}
