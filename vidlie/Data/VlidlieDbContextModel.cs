using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using vidlie.Models;

namespace VidlieDbContextModel
{
    public class VidlieDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=vidlie.db");
    }
}