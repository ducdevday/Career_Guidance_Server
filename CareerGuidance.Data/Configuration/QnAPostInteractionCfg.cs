﻿using CareerGuidance.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerGuidance.Data.Configuration
{
    public class QnAPostInteractionCfg : AuditableEntityCfg<QnAPostInteraction>, IEntityTypeConfiguration<QnAPostInteraction>
    {
        public override void Configure(EntityTypeBuilder<QnAPostInteraction> builder)
        {
            base.Configure(builder);
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.IsUp).IsRequired();
            builder.Property(x => x.IsDown).IsRequired();
            builder.HasOne(x => x.QnAPost).WithMany(x => x.QnAPostInteractions).HasForeignKey(x => x.QnAPostId);
        }
    }
}
