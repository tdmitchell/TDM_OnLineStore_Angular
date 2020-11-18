using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TDM_OnLineStore.Dominium.Models.Entity;

namespace TDM_OnLineStore.Repository.Config
{
    class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);

            //Builder uses the Fluent pattern
            builder
                .Property(o => o.OrderDate)
                .IsRequired();

            builder
                .Property(o => o.DeliveryDate)
                .IsRequired();

            builder
                .Property(o => o.PostalCode)
                .IsRequired()
                .HasMaxLength(6);

            builder
               .Property(o => o.City)
               .IsRequired()
               .HasMaxLength(100);

            builder
               .Property(o => o.Province)
               .IsRequired()
               .HasMaxLength(100);

            builder
               .Property(o => o.Address)
               .IsRequired()
               .HasMaxLength(100);

            builder
                .Property(o => o.Number)
                .IsRequired();

            builder
                .HasOne(o => o.Payment);
        }
    }
}
