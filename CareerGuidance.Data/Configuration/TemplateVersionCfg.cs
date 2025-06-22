using CareerGuidance.Data.Entity;
using CareerGuidance.Shared.Constant;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Configuration
{
    public class TemplateVersionCfg : AuditableEntityCfg<TemplateVersion>, IEntityTypeConfiguration<TemplateVersion>
    {
        public override void Configure(EntityTypeBuilder<TemplateVersion> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Order)
                .IsRequired();

            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(ValidationConstant.DESCRIPTION_MAXLENGTH);

            builder.Property(x => x.Subject).IsRequired().HasMaxLength(ValidationConstant.TITLE_MAXLENGTH);

            builder.Property(x => x.Body)
                .IsRequired();

            builder.Property(x => x.IsDefault);
             
            builder.HasOne(x => x.Template).WithMany( x=> x.TemplateVersions).HasForeignKey(x => x.TemplateId);

            builder.HasMany(x => x.Notifications)
                   .WithOne(n => n.TemplateVersion)
                   .HasForeignKey(n => n.TemplateVersionId);

            builder.HasMany(x => x.TemplateFields)
                   .WithOne(tf => tf.TemplateVersion)
                   .HasForeignKey(tf => tf.TemplateVersionId);
        }
    }
}
