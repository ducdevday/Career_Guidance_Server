using CareerGuidance.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerGuidance.Shared.Constant;

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
                   .HasMaxLength(ValidationConstant.STREET_NO_MAXLENGTH);

            builder.Property(x => x.WardId)
                   .IsRequired()
                   .HasMaxLength(ValidationConstant.WARD_ID_MAXLENGTH);

            builder.Property(x => x.WardName)
                   .IsRequired()
                   .HasMaxLength(ValidationConstant.NAME_MAXLENGTH);

            builder.Property(x => x.DistrictId)
                   .IsRequired()
                   .HasMaxLength(ValidationConstant.DISTRICT_ID_MAXLENGTH);

            builder.Property(x => x.DistrictName)
                   .IsRequired()
                   .HasMaxLength(ValidationConstant.NAME_MAXLENGTH);

            builder.Property(x => x.ProvinceId)
                   .IsRequired()
                   .HasMaxLength(ValidationConstant.PROVINCE_ID_MAXLENGTH);

            builder.Property(x => x.ProvinceName)
                   .IsRequired()
                   .HasMaxLength(ValidationConstant.NAME_MAXLENGTH);
        }
    }
}
