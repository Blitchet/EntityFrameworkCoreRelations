using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreRelations
{
    class AppDbContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShopProduct> ShopsProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0AME2JN;Database=MyShop;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShopProduct>().HasKey(x => new { x.ShopId, x.ProductId});
        }
    }
}
