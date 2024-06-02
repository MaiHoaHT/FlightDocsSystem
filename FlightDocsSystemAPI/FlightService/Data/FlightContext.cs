using System.Collections.Generic;

namespace FlightService.Data
{
    public class FlightContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }

        public FlightContext(DbContextOptions<FlightContext> options) : base(options)
        {
        }
    }

}
