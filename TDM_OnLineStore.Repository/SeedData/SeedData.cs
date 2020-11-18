using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TDM_OnLineStore.Dominium.Models.Entity;

namespace TDM_OnLineStore.Repository.SeedData
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            ///Seed data
            modelBuilder.Entity<Payment>().HasData(
                new Payment()
                {
                    Id = 1,
                    Name = "Boleto",                        // ------------------------ !!!! TRANSLATE !!!! ------------------------ 
                    Description = "Payment by Boleto"       // ------------------------ !!!! TRANSLATE !!!! ------------------------ 
                },
                 new Payment()
                 {
                     Id = 2,
                     Name = "Credict Card",
                     Description = "Payment by Credict Card"
                 },
                 new Payment()
                 {
                     Id = 3,
                     Name = "Deposit",
                     Description = "Payment by Deposit"
                 }
                );

            ///Seed data
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Product Test 1",
                    Description = "Description for Product 1",
                    Price = 10
                },
                 new Product()
                 {
                     Id = 2,
                     Name = "Credict Card",
                     Description = "Description for Product 2",
                     Price = 20.2M
                 },
                 new Product()
                 {
                     Id = 3,
                     Name = "Deposit",
                     Description = "Description for Product 3",
                     Price = 30.3M
                 }
                );
        }
    }
}