using CareerGuidance.Data.Entity;
using CareerGuidance.Data.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Configuration
{
    public class MentorCfg : AuditableEntityCfg<Mentor>, IEntityTypeConfiguration<Mentor>
    {
        public override void Configure(EntityTypeBuilder<Mentor> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Industry).WithMany(x => x.Mentors).HasForeignKey(x => x.IndustryId);
            builder.HasOne(x => x.Address)
                                        .WithOne(x => x.Mentor)
                                        .HasForeignKey<Mentor>(x => x.AddressId);
        }
    }
}
