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
    public class CompanyCfg : AuditableEntityCfg<Company>, IEntityTypeConfiguration<Company>
    {
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
            builder.Property(c => c.FullName)
                .IsRequired()
                .HasMaxLength(ValidationConstant.NAME_MAXLENGTH);
            builder.Property(c => c.ShortName).IsRequired().HasMaxLength(ValidationConstant.SHORT_NAME_MAXLENGTH);
            builder.Property(c => c.EstablishmentDate).IsRequired();
            builder.HasOne(x => x.Address)
                .WithOne(x => x.Company)
                .HasForeignKey<Company>(x => x.AddressId);
        }
    }
}
