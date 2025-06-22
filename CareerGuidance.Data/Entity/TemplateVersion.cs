using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class TemplateVersion : AuditableEntity
    {
        public Guid Id { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsDefault { get; set; }

        public Guid TemplateId { get; set; }
        public Template Template { get; set; }

        public List<Notification>? Notifications { get; set; }
        public List<TemplateField>? TemplateFields { get; set; }
    }
}
