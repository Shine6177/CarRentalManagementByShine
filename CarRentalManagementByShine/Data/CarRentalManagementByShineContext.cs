using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRentalManagementByShine.Domain;
using CarRentalManagementByShine.Configurations.Entities;

namespace CarRentalManagementByShine.Data
{
    public class CarRentalManagementByShineContext : DbContext
    {
        public CarRentalManagementByShineContext(DbContextOptions<CarRentalManagementByShineContext> options)
            : base(options)
        {
        }

        public DbSet<CarRentalManagementByShine.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagementByShine.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagementByShine.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagementByShine.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManagementByShine.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagementByShine.Domain.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ColourSeed());
            modelBuilder.ApplyConfiguration(new MakeSeed());
            modelBuilder.ApplyConfiguration(new ModelSeed());
        }
    }
}
