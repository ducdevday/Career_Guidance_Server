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
    public class RefreshTokenCfg : AuditableEntityCfg<RefreshToken>, IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            base.Configure(builder);

            builder.HasKey(x => x.Id);

            builder.Property(x => x.TokenHash)
                    .IsRequired();

            builder.Property(rt => rt.ExpiresAt)
                    .IsRequired();

            builder.Property(rt => rt.IsUsed)
                    .HasDefaultValue(false);

            builder.Property(rt => rt.IsRevoked)
                    .HasDefaultValue(false);  

            builder.HasIndex(rt => rt.TokenHash).IsUnique();
        }
    }
}
