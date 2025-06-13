using CareerGuidance.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerGuidance.Data.Enum;

namespace CareerGuidance.Data.Configuration
{
    public class UserCfg : AuditableEntityCfg<User>, IEntityTypeConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Email).IsUnique();

            builder.HasIndex(x => x.PhoneNumber).IsUnique();

            builder.Property(x => x.Email)
                   .IsRequired()
                   .HasMaxLength(256);

            builder.Property(x => x.PhoneNumber)
                   .HasMaxLength(20);

            builder.Property(x => x.Password)
                   .IsRequired();

            builder.Property(x => x.Role)
                   .IsRequired()
                   .HasConversion(
                                 appToDb => appToDb.ToString(),
                                 dbToApp => System.Enum.Parse<RoleType>(dbToApp));

            builder.Property(x => x.Status)
                   .IsRequired()
                   .HasConversion(
                                 appToDb => appToDb.ToString(),
                                 dbToApp => System.Enum.Parse<AccountStatusType>(dbToApp));

            builder.HasOne(x => x.Address)
                   .WithOne()
                   .HasForeignKey<User>(x => x.AddressId)
                   .OnDelete(DeleteBehavior.SetNull);

            // ─── Discriminator cho TPH ─────────────────────────────────────────────
            builder.HasDiscriminator<string>("Discriminator")
                    .HasValue<Admin>("Admin")
                   .HasValue<Student>("Student");
        }
    }
}