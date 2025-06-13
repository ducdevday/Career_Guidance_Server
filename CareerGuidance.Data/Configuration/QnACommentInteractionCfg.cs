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
    public class QnACommentInteractionCfg : AuditableEntityCfg<QnACommentInteraction>, IEntityTypeConfiguration<QnACommentInteraction>
    {
        public override void Configure(EntityTypeBuilder<QnACommentInteraction> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.IsUp).IsRequired();
            builder.Property(x => x.IsDown).IsRequired();
            builder.HasOne(x => x.QnAComment).WithMany(x => x.QnACommentInteractions).HasForeignKey(x => x.QnACommentId);
        }
    }
}
