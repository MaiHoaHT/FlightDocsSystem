using FlightDocsSystemAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace FlightDocsSystemAPI.Data
{
    public class IntegrationContext : DbContext
    {
        public DbSet<FlightViewAPI> FlightViewAPIs { get; set; }

        public IntegrationContext(DbContextOptions<IntegrationContext> options) : base(options)
        {
        }
    }

}
