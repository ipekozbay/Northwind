using System;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{

    public class NorthwindContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = "Host=myserver;Username=mylogin;Password=1234;Database=Northwind";
        }

        public DbSet <Product > Products { get; set; }
        public DbSet <Category> categories { get; set; }
        public DbSet<Customer> customers { get; set; }

    }
}