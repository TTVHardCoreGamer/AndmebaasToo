using System.ComponentModel.DataAnnotations;


namespace AndmebaasiToo.Core.Domain
{
    public class Aircraft
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(20)]
        public string RegistrationNumber { get; set; }
        [MaxLength(100)]
        public string Model { get; set; }
        public int SeatCount { get; set; }
        public int ManufactureYear { get; set; }

        public ICollection<Flight> Flights { get; set; }
            = new List<Flight>();
    }
}
