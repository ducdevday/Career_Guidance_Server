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
    public class WardCfg : IEntityTypeConfiguration<Ward>
    {
        public void Configure(EntityTypeBuilder<Ward> builder)
        {
            builder.ToTable("Ward");
            builder.HasKey(x => x.WardId);
            builder.Property(x => x.WardId).ValueGeneratedNever();
            builder.Property(x => x.WardName).HasMaxLength(200).IsRequired();
            builder.HasOne(x => x.District)
             .WithMany(d => d.Wards)
             .HasForeignKey(x => x.DistrictId)
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
