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
    public class TemplateFieldCfg : AuditableEntityCfg<TemplateField>, IEntityTypeConfiguration<TemplateField>
    {
        public void Configure(EntityTypeBuilder<TemplateField> builder)
        {
            builder.HasKey(X => X.Id);
            builder.HasIndex(x => x.TemplateVersionId);
            builder.Property(x => x.Type).IsRequired().HasConversion(
                appToDb => appToDb.ToString(),
                dbToApp => System.Enum.Parse<NotificationFieldType>(dbToApp)
            );
            builder.Property(x => x.Name).IsUnicode().IsRequired();
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.IsSubject).IsRequired();
            builder.Property(x => x.IsBody).IsRequired();
            builder.HasOne(x => x.TemplateVersion).WithMany(x => x.TemplateFields).HasForeignKey(x => x.TemplateVersionId);
        }
    }
}
