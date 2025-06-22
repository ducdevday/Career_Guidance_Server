using CareerGuidance.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class EmailVerification : AuditableEntity
    {
        public Guid Id { get; set; }           
        public string Token { get; set; }     
        public DateTime ExpiresAt { get; set; }
        public bool IsUsed { get; set; }
        public EmailVerificationType Type { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
