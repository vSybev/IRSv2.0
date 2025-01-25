using Microsoft.EntityFrameworkCore;
using IRSv2._0.Models;

namespace IRSv2._0.Data.Contexts
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options) { }

        public DbSet<OrdersModel> Orders { get; set; }
        public DbSet<ProductsModel> Products { get; set; }
        public DbSet<CooksModel> Cooks { get; set; }
    }
}
