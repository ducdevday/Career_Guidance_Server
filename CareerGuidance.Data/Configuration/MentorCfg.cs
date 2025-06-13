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
            builder.Property(m => m.FirstName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(m => m.LastName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(m => m.MiddleName).HasMaxLength(100);

            builder.Property(s => s.Gender)
                                         .IsRequired()
                                         .HasConversion(
                                             appToDB => appToDB.ToString(),
                                             dbToApp => System.Enum.Parse<GenderType>(dbToApp)
                                             );

            builder.Property(s => s.DateOfBirth)
                   .IsRequired();
        }
    }
}
