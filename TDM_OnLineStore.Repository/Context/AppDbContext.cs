using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TDM_OnLineStore.Dominium.Models.Entity;
using TDM_OnLineStore.Repository.Config;
using TDM_OnLineStore.Repository.SeedData;

namespace TDM_OnLineStore.Repository
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        ///Mapping Properties and Relationships (Construct the Model for this Context)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///Inform ALL Configuration Classes here            
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            ///Seed Data (Hard Coded Data)
            modelBuilder.Seed();

            base.OnModelCreating(modelBuilder);
        }
    }
}