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
    public class BlogConfiguration : AuditableEntityCfg<Blog>, IEntityTypeConfiguration<Blog>
    {
        public override void Configure(EntityTypeBuilder<Blog> builder)
        {
            base.Configure(builder); 

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.ThumnailUrl)
                   .IsRequired()
                   .HasMaxLength(500);

            builder.Property(x => x.Title)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(x => x.Content)
                   .IsRequired();

            builder.Property(x => x.TimeForReadValue)
                   .IsRequired();

            builder.Property(x => x.TimeForReadType)
                   .IsRequired()
                   .HasConversion(
                                appToDb => appToDb.ToString(),
                                dbToApp => System.Enum.Parse<TimeType>(dbToApp));

            builder.Property(x => x.Status)
                   .HasDefaultValue(BlogStatusType.Draft);

            builder.HasOne(x => x.Industry)
                   .WithMany(x => x.Blogs)
                   .HasForeignKey(x => x.IndustryId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
