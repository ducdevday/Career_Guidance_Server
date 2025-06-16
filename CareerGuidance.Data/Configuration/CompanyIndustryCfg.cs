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
    public class CompanyIndustryCfg : AuditableEntityCfg<CompanyIndustry>, IEntityTypeConfiguration<CompanyIndustry>
    {
        public override void Configure(EntityTypeBuilder<CompanyIndustry> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => new { x.CompanyId, x.IndustryId });

            builder
                   .HasOne(x => x.Company)
                   .WithMany(x => x.CompanyIndustries)
                   .HasForeignKey(x => x.CompanyId);

            builder
                    .HasOne(x => x.Industry)
                    .WithMany(x => x.CompanyIndustries)
                    .HasForeignKey(x => x.IndustryId);
        }
    }
}
