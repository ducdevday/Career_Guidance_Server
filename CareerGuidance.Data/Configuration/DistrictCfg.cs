using CareerGuidance.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Configuration
{
    public class DistrictCfg : IEntityTypeConfiguration<District>
    {
        public void Configure(EntityTypeBuilder<District> builder)
        {
            builder.ToTable("District");
            builder.HasKey(x => x.DistrictId);
            builder.Property(x => x.DistrictId).ValueGeneratedNever(); // Assuming DistrictId is not auto-generated
            builder.Property(x => x.DistrictName).HasMaxLength(200).IsRequired();
            builder.HasOne(x => x.Province)
             .WithMany(p => p.Districts)
             .HasForeignKey(x => x.ProvinceId)
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
