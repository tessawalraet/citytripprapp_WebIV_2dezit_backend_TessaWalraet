using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CityTrippr.Models
{
    public class AuthenticationContext : IdentityDbContext
    {
        public AuthenticationContext(DbContextOptions<AuthenticationContext> options)
            :base(options)
        {

        }

        public DbSet<ApplicationUser> AppUsers { get; set; }
    }
}
