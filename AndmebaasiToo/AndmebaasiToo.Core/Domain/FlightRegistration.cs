using System.ComponentModel.DataAnnotations;


namespace AndmebaasiToo.Core.Domain
{
    public class FlightRegistration
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(10)]
        public string SeatNumber { get; set; }
        public DateTime RegistrationTime { get; set; }
        [MaxLength(50)]
        public string TicketType { get; set; }

        public Guid PassengerId { get; set; }
        public Passenger Passenger { get; set; }
        public Guid FlightId { get; set; }
        public Flight Flight { get; set; }

        public ICollection<Baggage> Baggages { get; set; }
            = new List<Baggage>();
    }
}
