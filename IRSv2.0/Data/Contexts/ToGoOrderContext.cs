using Microsoft.EntityFrameworkCore;
using IRSv2._0.Models;

namespace IRSv2._0.Data.Contexts
{
    public class ToGoOrderContext : DbContext
    {
        public ToGoOrderContext(DbContextOptions<ToGoOrderContext> options) : base(options) { }

        public DbSet<ToGoOrdersModel> ToGoOrders { get; set; }
    }
}