using CareerGuidance.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class TemplateField : AuditableEntity
    {
        public Guid Id { get; set; }
        public NotificationFieldType Type { get; set; }
        public string Name { get; set; }
        public bool IsSubject { get; set; }
        public bool IsBody { get; set; }
        public DateTime CreatedDate { get; set; }

        public Guid TemplateVersionId { get; set; }
        public TemplateVersion TemplateVersion { get; set; }
    }
}
