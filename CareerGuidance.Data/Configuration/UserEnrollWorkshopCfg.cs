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
    public class UserEnrollWorkshopCfg : AuditableEntityCfg<UserEnrollWorkshop>, IEntityTypeConfiguration<UserEnrollWorkshop>
    {
        public override void Configure(EntityTypeBuilder<UserEnrollWorkshop> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => new { x.UserId, x.WorkshopId });

            builder
                   .HasOne(x => x.User)
                   .WithMany(x => x.UserEnrollWorkshops)
                   .HasForeignKey(x => x.UserId);


            builder
                    .HasOne(x => x.Workshop)
                    .WithMany(x => x.UserEnrollWorkshops)
                    .HasForeignKey(x => x.WorkshopId);
        }
    }
}
