using CareerGuidance.Data.Entity;
using CareerGuidance.Shared.Constant;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Configuration
{
    public class EmailVerificationCfg : AuditableEntityCfg<EmailVerification>, IEntityTypeConfiguration<EmailVerification>
    {
        public void Configure(EntityTypeBuilder<EmailVerification> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Token)
                .IsRequired()
                .HasMaxLength(ValidationConstant.EMAIL_VERIFICATION_CODE_LENGTH);

            builder.Property(x => x.ExpiresAt)
                .IsRequired();

            builder.Property(x => x.IsUsed)
                .HasDefaultValue(false);

            builder.Property(x => x.Type)
                .IsRequired();

            builder.HasOne(x => x.User)
                .WithMany() 
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
