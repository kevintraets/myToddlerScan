
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using ToddlerScan.Domain;

namespace ToddlerScan.Data
{
    public class ToddlerScanContext: DbContext
    {

        //Console logging, delete after useless

        public static readonly LoggerFactory MyConsoleLoggerFactory
            = new LoggerFactory(new[]
            {
                new ConsoleLoggerProvider((category, level)
                    => category == DbLoggerCategory.Database.Command.Name
                       && level == LogLevel.Information, true)
            });
        public DbSet<Scan> Scans { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Toddler> Toddlers { get; set; }
        public DbSet<Domain.ToddlerScan> ToddlerScans { get; set; }
        public DbSet<ToddlerTrip> ToddlerTrips { get; set; }
        public DbSet<Trip> Trips { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(MyConsoleLoggerFactory)
                .UseSqlServer(
                "Server = (localdb)\\mssqllocaldb; Database = ToddlerScanData; Trusted_Connection = true; ");
        }
    }
}
