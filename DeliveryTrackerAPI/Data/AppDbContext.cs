using Microsoft.EntityFrameworkCore;

namespace DeliveryTrackerAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DriverDeliveries>()
                .HasKey(ep => new { ep.DeliveryId, ep.DriverId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Delivery> Deliveries  { get; set; }
        public DbSet<DriverDeliveries> DriverDeliveries { get; set; }
    }
}
