using Microsoft.EntityFrameworkCore;

namespace Sklad1.Data
{
    internal class Context : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Shipment> shipments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=Sklad_BD;Username=postgres;Password=admin123");
        }
    }
}
