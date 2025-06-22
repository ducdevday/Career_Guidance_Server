using CareerGuidance.Data.Entity;
using CareerGuidance.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DataAccess.Data.Interface
{
    public interface IEmailVerificationData
    {
        public Task<EmailVerification> AddEmailVerificationAsync(EmailVerification emailVerification);
        public Task<EmailVerification?> GetEmailVerificationByUserIdAsync(Guid userId, EmailVerificationType type, bool asNoTracking = false);
        public Task<EmailVerification?> UpdateEmailVerificationAsync(EmailVerification emailVerification);
    }
}
