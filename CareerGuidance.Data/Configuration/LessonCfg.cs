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
    public class LessonCfg : AuditableEntityCfg<Lesson>, IEntityTypeConfiguration<Lesson>
    {
        public override void Configure(EntityTypeBuilder<Lesson> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(ValidationConstant.NAME_MAXLENGTH);

            builder.Property(x => x.Description).IsRequired();

            builder.Property(x => x.VideoUrl).IsRequired().HasMaxLength(ValidationConstant.URL_MAXLENGTH);

            builder.Property(x => x.ThumnalUrl).IsRequired().HasMaxLength(ValidationConstant.URL_MAXLENGTH);

            builder.HasOne(x => x.Chapter).WithMany(x => x.Lessons).HasForeignKey(x => x.ChapterId);

        }
    }
}
