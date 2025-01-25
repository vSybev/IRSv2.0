using Microsoft.EntityFrameworkCore;
using IRSv2._0.Models;

namespace IRSv2._0.Data.Contexts
{
    public class StorageItemContext : DbContext
    {
        public StorageItemContext(DbContextOptions<StorageItemContext> options) : base(options) { }

        public DbSet<StorageItemsModel> StorageItems { get; set; }
    }
}
