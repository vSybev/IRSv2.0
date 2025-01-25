using Microsoft.EntityFrameworkCore;
using IRSv2._0.Models;

namespace IRSv2._0.Data.Contexts
{
    public class TableContext : DbContext
    {
        public TableContext(DbContextOptions<TableContext> options) : base(options) { }

        public DbSet<TablesModel> Tables { get; set; }
    }
}