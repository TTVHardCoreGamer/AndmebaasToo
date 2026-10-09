using Microsoft.EntityFrameworkCore;
using AndmebaasiToo.Core.Domain;


namespace AndmebaasiToo.Data
{
    public class AndmebaasiTooDbContext : DbContext
    {
        public AndmebaasiTooDbContext(DbContextOptions<AndmebaasiTooDbContext> options)
            : base(options)
        {
        }

        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Gate> Gates { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<FlightRegistration> FlightRegistrations { get; set; }
        public DbSet<Baggage> Baggages { get; set; }
        public DbSet<FlightEmployee> FlightEmployees { get; set; }
        public DbSet<FlightStatusChange> FlightStatusChanges { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Flight>()
                .HasOne(f => f.DepartureAirport)
                .WithMany(a => a.DepartingFlights)
                .HasForeignKey(f => f.DepartureAirportId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Flight>()
                .HasOne(f => f.ArrivalAirport)
                .WithMany(a => a.ArrivingFlights)
                .HasForeignKey(f => f.ArrivalAirportId)
                .OnDelete(DeleteBehavior.Restrict);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<DateTime>().HaveColumnType("datetime");
        }
    }
}
