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
    public class CourseCfg : AuditableEntityCfg<Course>, IEntityTypeConfiguration<Course>
    {
        public override void Configure(EntityTypeBuilder<Course> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.VideoAdsUrl).IsRequired().HasMaxLength(ValidationConstant.URL_MAXLENGTH);
            builder.Property(x => x.ThumnalUrl).IsRequired().HasMaxLength(ValidationConstant.URL_MAXLENGTH);
            builder.Property(x => x.Status).HasDefaultValue(CourseStatusType.Draft).HasConversion(appToDb => appToDb.ToString(), dbToApp => System.Enum.Parse<CourseStatusType>(dbToApp));
            builder.HasOne(x => x.Industry).WithMany(x => x.Courses)
                .HasForeignKey(x => x.IndustryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
