using CarRentalManagementByShine.Configurations.Entities;
using CarRentalManagementByShine.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagementByShine.Data
{
    public class CarRentalManagementByShineContext(DbContextOptions<CarRentalManagementByShineContext> options)
        : IdentityDbContext<CarRentalManagementByShineUser>(options)
    {
        public DbSet<Make> Make { get; set; } = default!;
        public DbSet<Model> Model { get; set; } = default!;
        public DbSet<Colour> Colour { get; set; } = default!;
        public DbSet<Vehicle> Vehicle { get; set; } = default!;
        public DbSet<Booking> Booking { get; set; } = default!;
        public DbSet<Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ColourSeed());
            modelBuilder.ApplyConfiguration(new MakeSeed());
            modelBuilder.ApplyConfiguration(new ModelSeed());
            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}
