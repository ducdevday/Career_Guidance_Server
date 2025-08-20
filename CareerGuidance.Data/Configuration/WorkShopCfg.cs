using CareerGuidance.Data.Entity;
using CareerGuidance.Data.Enum;
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
    public class WorkShopCfg : AuditableEntityCfg<Workshop>, IEntityTypeConfiguration<Workshop>
    {
        public override void Configure(EntityTypeBuilder<Workshop> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(ValidationConstant.NAME_MAXLENGTH);
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Thumnail).IsRequired().HasMaxLength(ValidationConstant.URL_MAXLENGTH);
            builder.Property(x => x.Duration).IsRequired();
            builder.Property(x => x.TimeType).IsRequired().HasConversion(appToDb => appToDb.ToString(), dbToApp => System.Enum.Parse<TimeType>(dbToApp));
            builder.Property(x => x.Status).IsRequired().HasDefaultValue(TourStatusType.Draft).IsRequired().HasConversion(appToDb => appToDb.ToString(), dbToApp => System.Enum.Parse<TourStatusType>(dbToApp));
            builder.HasOne(x => x.Industry).WithMany(x => x.Workshops).HasForeignKey(x => x.IndustryId);
            builder.HasOne(w => w.Province)
             .WithMany() 
             .HasForeignKey(w => w.ProvinceId)
             .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(w => w.District)
                   .WithMany()
                   .HasForeignKey(w => w.DistrictId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(w => w.Ward)
                   .WithMany()
                   .HasForeignKey(w => w.WardId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Child collections
            builder.HasMany(w => w.UserEnrollWorkshops)
                   .WithOne(ue => ue.Workshop)
                   .HasForeignKey(ue => ue.WorkshopId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(w => w.WorkshopReviews)
                   .WithOne(r => r.Workshop)
                   .HasForeignKey(r => r.WorkshopId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
