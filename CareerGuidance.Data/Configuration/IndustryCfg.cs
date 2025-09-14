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
    public class IndustryCfg : AuditableEntityCfg<Industry>, IEntityTypeConfiguration<Industry>
    {
        public override void Configure(EntityTypeBuilder<Industry> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(ValidationConstant.NAME_MAXLENGTH);
            builder.Property(x => x.Icon).IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(x => x.Name).IsUnique();

        }
    }
}
