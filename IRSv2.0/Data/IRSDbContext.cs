using IRSv2._0.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IRSv2._0.Data
{
    public class IRSDbContext:DbContext
    {
        private readonly string _connectionString;

        /*public IRSDbContext(DbContextOptions<IRSDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _connectionString = configuration.GetConnectionString("IRSDbConnect");
        }*/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PD-VSABEV;Database=IRSDBv2.0;TrustServerCertificate=True;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }

        public DbSet<Cook> Cooks { get; set; }
        public DbSet<Deliverer> Deliverers { get; set; }
        public DbSet<Models.Host> Hosts { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<StorageItem> StorageItems { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<ToGoOrder> ToGoOrders { get; set; }
        public DbSet<Waiter> Waiters { get; set; }

    }
}
