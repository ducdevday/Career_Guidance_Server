using CareerGuidance.Data.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerGuidance.Data.Enum;
using CareerGuidance.Shared.Constant;

namespace CareerGuidance.Data.Configuration
{
    public class UserCfg : AuditableEntityCfg<User>, IEntityTypeConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(m => m.FirstName)
                                            .IsRequired()
                                            .HasMaxLength(ValidationConstant.NAME_MAXLENGTH);

            builder.Property(m => m.LastName)
                .IsRequired()
                .HasMaxLength(ValidationConstant.NAME_MAXLENGTH);

            builder.Property(m => m.MiddleName).HasMaxLength(ValidationConstant.NAME_MAXLENGTH);

            builder.Property(s => s.Gender)
                                         .IsRequired()
                                         .HasConversion(
                                             appToDB => appToDB.ToString(),
                                             dbToApp => System.Enum.Parse<GenderType>(dbToApp)
                                             );

            builder.Property(s => s.DateOfBirth)
                   .IsRequired();

            builder.HasIndex(x => x.Email).IsUnique();

            builder.HasIndex(x => x.PhoneNumber).IsUnique();

            builder.Property(x => x.Email)
                   .IsRequired()
                   .HasMaxLength(ValidationConstant.EMAIL_MAXLENGTH);

            builder.Property(x => x.PhoneNumber)
                   .HasMaxLength(ValidationConstant.PHONE_MAXLENGTH);

            builder.Property(x => x.Password)
                   .IsRequired();

            builder.Property(x => x.Role)
                   .IsRequired()
                   .HasConversion(
                                 appToDb => appToDb.ToString(),
                                 dbToApp => System.Enum.Parse<RoleType>(dbToApp));

            builder.Property(x => x.Status)
                   .HasDefaultValue(AccountStatusType.Unverified)
                   .HasConversion(
                                 appToDb => appToDb.ToString(),
                                 dbToApp => System.Enum.Parse<AccountStatusType>(dbToApp));
        }
    }
}