
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Scan>()
                .HasMany(s => s.ToddlerScans);

            modelBuilder.Entity<Trip>()
                .HasMany(t => t.Toddlers);

            modelBuilder.Entity<Toddler>()
                .Property(t => t.FirstName)
                .IsRequired();

            Toddler toddlerSeed = new Toddler
            {
                Id = 1,
                FirstName = "Kevin",
                LastName = "Traets",
                Grade = "3"
            };
            Teacher teacherSeed = new Teacher
            {
                Id=1,
                FirstName = "Kris",
                LastName = "Hermans"
            };

            Trip tripSeed = new Trip
            {
                Id = 1,
                Date = DateTime.Now,
                TeacherId = teacherSeed.Id,
                Title = "Zee"
            };
            Scan scanSeed = new Scan
            {
                Id = 1,
                Name = "Middagpauze",
                TeacherId = teacherSeed.Id,
                TripId = tripSeed.Id,
            };
            ToddlerTrip toddlerTripSeed = new ToddlerTrip
            {
                Id = 1,
                ToddlerId = toddlerSeed.Id,
                TripId = tripSeed.Id
            };
            modelBuilder.Entity<Toddler>().HasData(toddlerSeed);
            modelBuilder.Entity<Teacher>().HasData(teacherSeed);
            modelBuilder.Entity<Trip>().HasData(tripSeed);
            modelBuilder.Entity<Scan>().HasData(scanSeed);
            modelBuilder.Entity<ToddlerTrip>().HasData(toddlerTripSeed);
        }

    }
}
