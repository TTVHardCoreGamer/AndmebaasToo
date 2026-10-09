using System.ComponentModel.DataAnnotations;


namespace AndmebaasiToo.Core.Domain
{
    public class Passenger
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        [MaxLength(30)]
        public string DocumentNumber { get; set; }
        [MaxLength(20)]
        public string Telephone { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }

        public ICollection<FlightRegistration> FlightRegistrations { get; set; }
            = new List<FlightRegistration>();
    }
}
