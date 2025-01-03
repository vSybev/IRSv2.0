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

        public DbSet<CooksModel> Cooks { get; set; }
        public DbSet<DeliverersModel> Deliverers { get; set; }
        public DbSet<Models.HostsModel> Hosts { get; set; }
        public DbSet<ManagersModel> Managers { get; set; }
        public DbSet<OrdersModel> Orders { get; set; }
        public DbSet<ProductsModel> Products { get; set; }
        public DbSet<StorageItemsModel> StorageItems { get; set; }
        public DbSet<TablesModel> Tables { get; set; }
        public DbSet<ToGoOrdersModel> ToGoOrders { get; set; }
        public DbSet<WaitersModel> Waiters { get; set; }

    }
}
