using CareerGuidance.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Configuration
{
    public class AddressConfiguration : AuditableEntityCfg<Address>, IEntityTypeConfiguration<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.StreetNo)
                   .HasMaxLength(255);

            builder.Property(x => x.WardId)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(x => x.WardName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.DistrictId)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(x => x.DistrictName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(x => x.ProvinceId)
                   .IsRequired()
                   .HasMaxLength(20);

            builder.Property(x => x.ProvinceName)
                   .IsRequired()
                   .HasMaxLength(100);
        }
    }
}
