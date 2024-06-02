using FlightService.Data;

namespace FlightService.Services
{
    public class FlightService
    {
        private readonly FlightContext _context;

        public FlightService(FlightContext context)
        {
            _context = context;
        }

        public async Task<Flight> GetFlightByIdAsync(int id)
        {
            return await _context.Flights.FindAsync(id);
        }

        public async Task CreateFlightAsync(Flight flight)
        {
            _context.Flights.Add(flight);
            await _context.SaveChangesAsync();
        }
    }

}
