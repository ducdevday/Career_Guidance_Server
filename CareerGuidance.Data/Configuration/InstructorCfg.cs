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
    public class InstructorCfg : AuditableEntityCfg<Instructor>, IEntityTypeConfiguration<Instructor>
    {
        public override void Configure(EntityTypeBuilder<Instructor> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Avatar).IsRequired().HasMaxLength(500);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(ValidationConstant.NAME_MAXLENGTH);

            builder.Property(x => x.Position)
                .IsRequired()
                .HasMaxLength(ValidationConstant.NAME_MAXLENGTH);

            builder.Property(x => x.Bio)
                .IsRequired()
                .HasMaxLength(ValidationConstant.BIO_MAXLENGTH);

            builder.HasOne(x => x.Course).WithMany(x => x.Instructors)
                .HasForeignKey(x => x.CourseId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
