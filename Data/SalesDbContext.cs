using Microsoft.EntityFrameworkCore;
using Models.Models;
using System.Reflection.Metadata;

namespace Data
{
    public class SalesDbContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Total> Totals { get; set; }
        public DbSet<Unit> Units { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SINEM\\SQLEXPRESS;Database=Sales;Integrated Security=True;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            {
                modelBuilder.Entity<Sales>().HasOne(s => s.Total).WithOne(t => t.Sales).HasForeignKey<Total>(t => t.Id);
                modelBuilder.Entity<Order>().HasOne(o => o.Sales).WithOne(s => s.Order).HasForeignKey<Order>(s => s.Id);
                modelBuilder.Entity<Sales>().HasOne(s => s.Unit).WithOne(u => u.Sales).HasForeignKey<Unit>(t => t.Id);
            }
        }


    }
}

