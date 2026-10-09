using System.ComponentModel.DataAnnotations;


namespace AndmebaasiToo.Core.Domain
{
    public class Flight
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(10)]
        public string FlightNumber { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        public Guid AirlineId { get; set; }
        public Airline Airline { get; set; }
        public Guid AircraftId { get; set; }
        public Aircraft Aircraft { get; set; }
        public Guid GateId { get; set; }
        public Gate Gate { get; set; }
        public Guid DepartureAirportId { get; set; }
        public Airport DepartureAirport { get; set; }
        public Guid ArrivalAirportId { get; set; }
        public Airport ArrivalAirport { get; set; }

        public ICollection<FlightRegistration> FlightRegistrations { get; set; }
            = new List<FlightRegistration>();
        public ICollection<FlightEmployee> FlightEmployees { get; set; }
            = new List<FlightEmployee>();
        public ICollection<FlightStatusChange> StatusChanges { get; set; }
            = new List<FlightStatusChange>();
    }
}
