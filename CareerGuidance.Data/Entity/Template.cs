using CareerGuidance.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class Template : AuditableEntity
    {
        public Guid Id { get; set; }
        public NotificationType Type { get; set; }
        public string DisplayName { get; set; }
        public NotificationCategory Category { get; set; }
        public bool IsEnabled { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<TemplateVersion>? TemplateVersions { get; set; }
    }
}
