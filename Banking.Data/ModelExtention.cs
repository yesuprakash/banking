using Banking.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace Banking.Data
{
    public static class ModelExtention
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasData(
               new Account
               {
                   Id = 1,
                   Name = "Joseph",
                   MonthlyCreditLimit = 100000.00m
               },
               new Account
               {
                   Id = 2,
                   Name = "Rajeev",
                   MonthlyCreditLimit = 50000.00m
               },
               new Account
               {
                   Id = 3,
                   Name = "Akhil",
                   MonthlyCreditLimit = 60000.00m
               });

            modelBuilder.Entity<Payment>().HasData(
                new 
                {
                    Id = 1,
                    TransactionDate = Convert.ToDateTime("01/09/2019"),
                    Amount = 10000.00m,
                    AccountId = 1
                },
                new 
                {
                    Id = 2,
                    TransactionDate = Convert.ToDateTime("05/09/2019"),
                    Amount = 15000.00m,
                    AccountId = 2
                },
                new 
                {
                    Id = 3,
                    TransactionDate = Convert.ToDateTime("05/09/2019"),
                    Amount = 5000.00m,
                    AccountId = 1
                }
                );
        }
    }
}
