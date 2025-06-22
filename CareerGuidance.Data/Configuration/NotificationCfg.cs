using CareerGuidance.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerGuidance.Data.Enum;

namespace CareerGuidance.Data.Configuration
{
    public class NotificationCfg : AuditableEntityCfg<Notification>, IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.UserId);
            builder.HasIndex(x => x.TemplateVersionId);
            builder.Property(x => x.Type).IsRequired().HasConversion(
                appToDb => appToDb.ToString(),
                dbToApp => System.Enum.Parse<NotificationType>(dbToApp)
            );
            builder.Property(x => x.Subject).IsUnicode().IsRequired();
            builder.Property(x => x.Body).IsUnicode().IsRequired();
            builder.Property(x => x.Recipient).IsRequired();
            builder.Property(x => x.IsRead).IsRequired();
            builder.Property(x => x.IsSent).IsRequired();
            builder.Property(x => x.SentDate).IsRequired();
            builder.HasOne(x => x.User).WithMany(x => x.Notifications).HasForeignKey(x => x.UserId);
            builder.HasOne(X => X.TemplateVersion).WithMany(x => x.Notifications).HasForeignKey(x => x.TemplateVersionId);
        }
    }
}
