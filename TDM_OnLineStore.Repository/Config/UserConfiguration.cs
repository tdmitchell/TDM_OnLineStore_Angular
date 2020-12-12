using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TDM_OnLineStore.Dominium.Models.Entity;

namespace TDM_OnLineStore.Repository.Config
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            ///Configuring the Properties
            //Builder uses the Fluent pattern
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(400);

            builder
                .Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(u => u.LastName)
                .IsRequired()
                .HasMaxLength(50);

            ///Configuring the Relationships
            builder
                .HasMany(u => u.Orders)
                .WithOne(o => o.User);
        }
    }
}
