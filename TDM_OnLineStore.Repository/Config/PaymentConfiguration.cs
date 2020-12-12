using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TDM_OnLineStore.Dominium.Models.Entity;

namespace TDM_OnLineStore.Repository.Config
{
    class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            ///Configuring the Properties
            //Builder uses the Fluent pattern
            builder.HasKey(pay => pay.Id);

            builder
                .Property(pay => pay.Name)
                .IsRequired()
                .HasMaxLength(50);
            
            builder
                .Property(pay => pay.Description)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
