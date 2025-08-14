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
    public class ProvinceCfg : IEntityTypeConfiguration<Province>
    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.ToTable("Province");
            builder.HasKey(x => x.ProvinceId);
            builder.Property(x => x.ProvinceId).ValueGeneratedNever(); // Assuming ProvinceId is not auto-generated
            builder.Property(x => x.ProvinceName).HasMaxLength(200).IsRequired();
            builder.Property(x => x.ProvinceType).HasMaxLength(100);
        }
    }
}
