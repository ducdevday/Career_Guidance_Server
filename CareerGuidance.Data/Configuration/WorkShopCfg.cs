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
    public class WorkShopCfg : AuditableEntityCfg<Workshop>, IEntityTypeConfiguration<Workshop>
    {
        public override void Configure(EntityTypeBuilder<Workshop> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Thumnail).IsRequired().HasMaxLength(500);
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.TimeType).IsRequired().HasConversion(appToDb => appToDb.ToString(), dbToApp => System.Enum.Parse<TimeType>(dbToApp));
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(TourStatusType.Draft).IsRequired().HasConversion(appToDb => appToDb.ToString(), dbToApp => System.Enum.Parse<TourStatusType>(dbToApp));
            builder.HasOne(x => x.Industry).WithMany(x => x.Workshops).HasForeignKey(x => x.IndustryId);
            builder.HasOne(x => x.Address).WithOne(x => x.Workshop).HasForeignKey<Workshop>(x => x.AddressId);
        }
    }
}
