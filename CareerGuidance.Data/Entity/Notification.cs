using CareerGuidance.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Notification : AuditableEntity
    {
        public Guid Id { get; set; }
        public NotificationType Type { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Recipient { get; set; }
        public bool IsRead { get; set; }
        public bool IsSent { get; set; }
        public DateTime SentDate { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }


        public Guid TemplateVersionId { get; set; }
        public TemplateVersion TemplateVersion { get; set; }
    }
}
