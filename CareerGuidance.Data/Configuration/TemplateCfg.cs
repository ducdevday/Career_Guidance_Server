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
    public class TemplateCfg : AuditableEntityCfg<Template>, IEntityTypeConfiguration<Template>
    {
        public void Configure(EntityTypeBuilder<Template> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Type).IsRequired().HasConversion(
                appToDb => appToDb.ToString(),
                dbToApp => System.Enum.Parse<NotificationType>(dbToApp)
            );
            builder.Property(x => x.DisplayName).IsUnicode().IsRequired();
            builder.Property(x => x.Category).IsRequired().HasConversion(
                appToDb => appToDb.ToString(),
                dbToApp => System.Enum.Parse<NotificationCategory>(dbToApp)
            );
            builder.Property(x => x.IsEnabled).IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
        }
    }
}
