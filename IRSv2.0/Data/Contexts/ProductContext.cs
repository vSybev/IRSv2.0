using Microsoft.EntityFrameworkCore;
using IRSv2._0.Models;

namespace IRSv2._0.Data.Contexts
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<ProductsModel> Products { get; set; }
    }
}