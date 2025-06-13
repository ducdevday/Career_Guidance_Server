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
    public class StudentCfg : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(s => s.FirstName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(s => s.LastName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(s => s.MiddleName)
                   .HasMaxLength(100);

            builder.Property(s => s.Gender)
                   .IsRequired()
                   .HasConversion(
                       appToDB => appToDB.ToString(),
                       dbToApp =>System.Enum.Parse<GenderType>(dbToApp)
                       );

            builder.Property(s => s.DateOfBirth)
                   .IsRequired();
        }
    }
}
