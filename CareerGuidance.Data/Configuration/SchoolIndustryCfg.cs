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
    public class SchoolIndustryCfg : AuditableEntityCfg<SchoolIndustry>, IEntityTypeConfiguration<SchoolIndustry>
    {
        public override void Configure(EntityTypeBuilder<SchoolIndustry> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => new { x.SchoolId, x.IndustryId });

            builder
                    .HasOne(x => x.Industry)
                    .WithMany(x => x.SchoolIndustries)
                    .HasForeignKey(x => x.IndustryId);
        }
    }
}
