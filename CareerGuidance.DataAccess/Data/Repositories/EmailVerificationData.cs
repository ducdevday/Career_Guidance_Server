using CareerGuidance.Data;
using CareerGuidance.Data.Entity;
using CareerGuidance.Data.Enum;
using CareerGuidance.DataAccess.Data.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.DataAccess.Data.Repositories
{
    public class EmailVerificationData : IEmailVerificationData
    {
        private readonly CareerGuidanceDBContext _context;
        public EmailVerificationData(CareerGuidanceDBContext context)
        {
            _context = context;
        }
        public  Task<EmailVerification> AddEmailVerificationAsync(EmailVerification emailVerification)
        {
            var addedEntity =  _context.EmailVerification.Add(emailVerification);
            return Task.FromResult(addedEntity.Entity);
        }

        public Task<EmailVerification?> GetEmailVerificationByUserIdAsync(Guid userId, EmailVerificationType type, bool asNoTracking = false)
        {
            IQueryable<EmailVerification> query = _context.EmailVerification;
            if (asNoTracking)
            {
                query = query.AsNoTracking();
            }
            var emailVerification = query.OrderByDescending(l => l.InsertDate)
                .FirstOrDefault(l => l.UserId == userId && l.Type == type)
                ;
            return Task.FromResult(emailVerification);
        }

        public Task<EmailVerification?> UpdateEmailVerificationAsync(EmailVerification emailVerification)
        {
            throw new NotImplementedException();
        }
    }
}
