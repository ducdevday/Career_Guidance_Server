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
    public class ChapterCfg : AuditableEntityCfg<Chapter>, IEntityTypeConfiguration<Chapter>
    {
        public override void Configure(EntityTypeBuilder<Chapter> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.Description).IsRequired().HasMaxLength(ValidationConstant.DESCRIPTION_MAXLENGTH);

            builder.HasOne(x => x.Course).WithMany(x => x.Chapters)
                   .HasForeignKey(x => x.CourseId)
                   .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
