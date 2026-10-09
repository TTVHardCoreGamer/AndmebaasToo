using System.ComponentModel.DataAnnotations;


namespace AndmebaasiToo.Core.Domain
{
    public class Airline
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Country { get; set; }
        [MaxLength(20)]
        public string Telephone { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }

        public ICollection<Flight> Flights { get; set; }
            = new List<Flight>();
    }
}
