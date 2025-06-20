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
    public class QnACommentCfg : AuditableEntityCfg<QnAComment>, IEntityTypeConfiguration<QnAComment>
    {
        public override void Configure(EntityTypeBuilder<QnAComment> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Content)
                .IsRequired()
                .HasMaxLength(ValidationConstant.CONTENT_MAXLENGTH);
            builder.HasOne(x => x.QnAPost)
                .WithMany(x => x.QnAComments)
                .HasForeignKey(x => x.QnAPostId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
