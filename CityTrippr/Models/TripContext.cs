using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
