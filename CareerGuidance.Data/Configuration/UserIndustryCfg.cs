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
    public class UserIndustryCfg : AuditableEntityCfg<UserIndustry>, IEntityTypeConfiguration<UserIndustry>
    {
        public override void Configure(EntityTypeBuilder<UserIndustry> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => new { x.UserId, x.IndustryId });

            builder
                   .HasOne(x => x.User)
                   .WithMany(x => x.UserIndustries)
                   .HasForeignKey(x => x.UserId);


            builder
                    .HasOne(x => x.Industry)
                    .WithMany(x => x.UserIndustries)
                    .HasForeignKey(x => x.IndustryId);
        }
    }
}
