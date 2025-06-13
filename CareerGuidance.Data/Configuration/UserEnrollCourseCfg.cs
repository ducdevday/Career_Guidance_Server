using CareerGuidance.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Configuration
{
    public class UserEnrollCourseCfg : AuditableEntityCfg<UserEnrollCourse>, IEntityTypeConfiguration<UserEnrollCourse>
    {
        public override void Configure(EntityTypeBuilder<UserEnrollCourse> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => new { x.UserId, x.CourseId });

            builder
                   .HasOne(x => x.User)
                   .WithMany(x => x.UserEnrollCourses)
                   .HasForeignKey(x => x.UserId);


            builder
                    .HasOne(x => x.Course)
                    .WithMany(x => x.UserEnrollCourses)
                    .HasForeignKey(x => x.CourseId);
        }
    }
}
