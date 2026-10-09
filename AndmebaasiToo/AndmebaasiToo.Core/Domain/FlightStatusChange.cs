using System.ComponentModel.DataAnnotations;


namespace AndmebaasiToo.Core.Domain
{
    public class FlightStatusChange
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Status { get; set; }
        public DateTime ChangeTime { get; set; }
        [MaxLength(200)]
        public string Reason { get; set; }

        public Guid FlightId { get; set; }
        public Flight Flight { get; set; }
    }
}
