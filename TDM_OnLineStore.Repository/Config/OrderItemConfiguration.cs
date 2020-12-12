using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TDM_OnLineStore.Dominium.Models.Entity;

namespace TDM_OnLineStore.Repository.Config
{
    class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            ///Configuring the Properties
            //Builder uses the Fluent pattern
            builder.HasKey(oItem => oItem.Id);

            builder
                .Property(oItem => oItem.ProductId)
                .IsRequired();
            
            builder
                .Property(oItem => oItem.Quantity)
                .IsRequired();
        }
    }
}
