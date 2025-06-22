using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Entity
{
    public class RefreshToken : AuditableEntity
    {
        public Guid Id { get; set; }         
        public string TokenHash { get; set; }  
        public DateTime ExpiresAt { get; set; }
        public bool IsUsed { get; set; }
        public bool IsRevoked { get; set; }
        public string? CreatedByIp { get; set; }
    }
}
