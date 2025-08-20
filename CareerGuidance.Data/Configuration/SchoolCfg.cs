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
    public class SchoolCfg : AuditableEntityCfg<School>, IEntityTypeConfiguration<School>
    {
        public override void Configure(EntityTypeBuilder<School> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
            builder.Property(c => c.FullName).IsRequired().HasMaxLength(ValidationConstant.NAME_MAXLENGTH);
            builder.Property(c => c.ShortName).IsRequired().HasMaxLength(ValidationConstant.SHORT_NAME_MAXLENGTH);
            builder.HasOne(m => m.User).WithOne(u => u.School).HasForeignKey<School>(s => s.Id).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(w => w.Province)
           .WithMany()
           .HasForeignKey(w => w.ProvinceId)
           .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(w => w.District)
                   .WithMany()
                   .HasForeignKey(w => w.DistrictId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(w => w.Ward)
                   .WithMany()
                   .HasForeignKey(w => w.WardId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
