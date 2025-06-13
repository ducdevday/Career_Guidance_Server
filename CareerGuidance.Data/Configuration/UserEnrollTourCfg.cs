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
    public class UserEnrollTourCfg : AuditableEntityCfg<UserEnrollTour>, IEntityTypeConfiguration<UserEnrollTour>
    {
        public override void Configure(EntityTypeBuilder<UserEnrollTour> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => new { x.UserId, x.TourId });

            builder
                   .HasOne(x => x.User)
                   .WithMany(x => x.UserEnrollTours)
                   .HasForeignKey(x => x.UserId);


            builder
                    .HasOne(x => x.Tour)
                    .WithMany(x => x.UserEnrollTours)
                    .HasForeignKey(x => x.TourId);
        }
    }
}
