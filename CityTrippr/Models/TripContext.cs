using Microsoft.EntityFrameworkCore;

namespace CityTrippr.Models
{
    public class TripContext: DbContext
    {
        public TripContext(DbContextOptions<TripContext> options)
            :base(options)
        {

        }

        public DbSet<Trip> Trips { get; set; }
    }
}
