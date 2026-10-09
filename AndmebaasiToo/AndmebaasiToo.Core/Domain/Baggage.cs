using System.ComponentModel.DataAnnotations;


namespace AndmebaasiToo.Core.Domain
{
    public class Baggage
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(20)]
        public string TagNumber { get; set; }
        public int Weight { get; set; }
        [MaxLength(50)]
        public string Type { get; set; }

        public Guid FlightRegistrationId { get; set; }
        public FlightRegistration FlightRegistration { get; set; }
    }
}
