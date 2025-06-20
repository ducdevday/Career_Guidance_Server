using CareerGuidance.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CareerGuidance.Data.Interceptors
{
    public class AuditSaveChangesInterceptor : SaveChangesInterceptor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AuditSaveChangesInterceptor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        private Guid? GetCurrentUserId()
        {
            var user = _httpContextAccessor.HttpContext?.User;
            var userId = user?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            return Guid.TryParse(userId, out var id) ? id : null;
        }

        public override InterceptionResult<int> SavingChanges(
            DbContextEventData eventData,
            InterceptionResult<int> result)
        {
            UpdateEntities(eventData.Context);
            return base.SavingChanges(eventData, result);
        }

        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
            DbContextEventData eventData,
            InterceptionResult<int> result,
            CancellationToken cancellationToken = default)
        {
            UpdateEntities(eventData.Context);
            return base.SavingChangesAsync(eventData, result, cancellationToken);
        }

        private void UpdateEntities(DbContext? context)
        {
            if (context == null) return;

            var userId = GetCurrentUserId();
            var now = DateTime.UtcNow;

            foreach (var entry in context.ChangeTracker.Entries<AuditableEntity>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.InsertDate = now;
                    entry.Entity.InsertById = userId;
                    entry.Entity.Active = true;
                }
                else if (entry.State == EntityState.Modified)
                {
                    entry.Entity.UpdatedDate = now;
                    entry.Entity.UpdatedById = userId;
                }
            }
        }
    }
}
