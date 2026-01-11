using CarRentalManagementByShine.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagementByShine.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<CarRentalManagementByShineUser>
    {
        public void Configure(EntityTypeBuilder<CarRentalManagementByShineUser> builder)
        {
            var hasher = new PasswordHasher<CarRentalManagementByShineUser>();

            builder.HasData(
                new CarRentalManagementByShineUser
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }
            );
        }
    }
}
