using CareerGuidance.Data.Entity;
using CareerGuidance.Data.Enum;
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
    public class ResourceCfg : AuditableEntityCfg<Resource>, IEntityTypeConfiguration<Resource>
    {
        public override void Configure(EntityTypeBuilder<Resource> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(ValidationConstant.NAME_MAXLENGTH);
            builder.Property(x => x.SourceUrl).IsRequired().HasMaxLength(ValidationConstant.URL_MAXLENGTH);
            builder.Property(x => x.SourceType).IsRequired();
            builder.HasOne(x => x.Lesson)
                .WithMany(x => x.Resources)
                .HasForeignKey(x => x.LessonId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
