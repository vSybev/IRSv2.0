using IRSv2._0.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IRSv2._0.Data
{
public class IRSDbContext : DbContext
    {
        // DbSets for all your entities
        public DbSet<CooksModel> Cooks { get; set; }
        public DbSet<DeliverersModel> Deliverers { get; set; }
        public DbSet<HostsModel> Hosts { get; set; }
        public DbSet<ManagersModel> Managers { get; set; }
        public DbSet<OrdersModel> Orders { get; set; }
        public DbSet<ProductsModel> Products { get; set; }
        public DbSet<StorageItemsModel> StorageItems { get; set; }
        public DbSet<TablesModel> Tables { get; set; }
        public DbSet<ToGoOrdersModel> ToGoOrders { get; set; }
        public DbSet<WaitersModel> Waiters { get; set; }

        // Constructor for Dependency Injection
        public IRSDbContext(DbContextOptions<IRSDbContext> options) : base(options) { }

        // Configure relationships and cascade delete behavior
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Many-to-Many: Cooks and Orders
            modelBuilder.Entity<CooksModel>()
                .HasMany(c => c.Orders)
                .WithMany(o => o.Cooks)
                .UsingEntity(j => j.ToTable("CooksOrders"));

            // Many-to-Many: Cooks and ToGoOrders
            modelBuilder.Entity<CooksModel>()
                .HasMany(c => c.ToGoOrders)
                .WithMany(t => t.Cooks)
                .UsingEntity(j => j.ToTable("CooksToGoOrders"));

            // Many-to-Many: Products and Orders
            modelBuilder.Entity<ProductsModel>()
                .HasMany(p => p.Orders)
                .WithMany(o => o.Products)
                .UsingEntity(j => j.ToTable("ProductsOrders"));

            // Many-to-Many: Products and ToGoOrders
            modelBuilder.Entity<ProductsModel>()
                .HasMany(p => p.ToGoOrders)
                .WithMany(t => t.Products)
                .UsingEntity(j => j.ToTable("ProductsToGoOrders"));

            // Many-to-Many: Products and StorageItems
            modelBuilder.Entity<StorageItemsModel>()
                .HasMany(s => s.Products)
                .WithMany(p => p.Items)
                .UsingEntity(j => j.ToTable("StorageItemsProducts"));

            // One-to-Many: Deliverers and ToGoOrders
            modelBuilder.Entity<DeliverersModel>()
                .HasMany(d => d.ToGoOrders)
                .WithOne(t => t.Deliverer)
                .HasForeignKey(t => t.DelivererID)
                .OnDelete(DeleteBehavior.Cascade);

            // One-to-Many: Hosts and Tables
            modelBuilder.Entity<HostsModel>()
                .HasMany(h => h.Sector)
                .WithOne(t => t.Host)
                .HasForeignKey(t => t.HostID)
                .OnDelete(DeleteBehavior.Cascade);

            // One-to-Many: Hosts and ToGoOrders
            modelBuilder.Entity<HostsModel>()
                .HasMany(h => h.ToGoOrders)
                .WithOne(t => t.Host)
                .HasForeignKey(t => t.HostID)
                .OnDelete(DeleteBehavior.Cascade);

            // One-to-Many: Managers and Employees (Waiters, Cooks, Hosts, Deliverers)
            modelBuilder.Entity<ManagersModel>()
                .HasMany(m => m.Waiters)
                .WithOne(w => w.Manager)
                .HasForeignKey(w => w.ManagerID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ManagersModel>()
                .HasMany(m => m.Cooks)
                .WithOne(c => c.Manager)
                .HasForeignKey(c => c.ManagerID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ManagersModel>()
                .HasMany(m => m.Hosts)
                .WithOne(h => h.Manager)
                .HasForeignKey(h => h.ManagerID)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ManagersModel>()
                .HasMany(m => m.Deliverers)
                .WithOne(d => d.Manager)
                .HasForeignKey(d => d.ManagerID)
                .OnDelete(DeleteBehavior.Cascade);

            // One-to-Many: Waiters and Tables
            modelBuilder.Entity<WaitersModel>()
                .HasMany(w => w.Sector)
                .WithOne(t => t.Waiter)
                .HasForeignKey(t => t.WaiterID)
                .OnDelete(DeleteBehavior.Cascade);

            // One-to-Many: Waiters and Orders
            modelBuilder.Entity<WaitersModel>()
                .HasMany(w => w.Orders)
                .WithOne(o => o.Waiter)
                .HasForeignKey(o => o.WaiterID)
                .OnDelete(DeleteBehavior.Cascade);

            // One-to-Many: Tables and Orders
            modelBuilder.Entity<TablesModel>()
                .HasOne(t => t.Order)
                .WithOne(o => o.Table)
                .HasForeignKey<OrdersModel>(o => o.TableID)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }

        // Configure multiple connection strings
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                // optionsBuilder.UseSqlServer(@"Server=DESKTOP-1KLCRTE;Database=IRSDBv2.0;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true;");
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-2T34TGN;Database=IRSDBv3.0;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true;");
                // optionsBuilder.UseSqlServer(@"Server=PD-VSABEV;Database=IRSDBv2.0;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true;");
            }
        }
    }

}










