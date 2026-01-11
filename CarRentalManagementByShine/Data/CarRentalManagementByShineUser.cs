using Microsoft.AspNetCore.Identity;

namespace CarRentalManagementByShine.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class CarRentalManagementByShineUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
