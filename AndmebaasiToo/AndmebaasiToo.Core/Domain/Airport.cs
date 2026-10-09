using System.ComponentModel.DataAnnotations;


namespace AndmebaasiToo.Core.Domain
{
    public class Airport
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(10)]
        public string Code { get; set; }
        [MaxLength(100)]
        public string Country { get; set; }

        public ICollection<Flight> DepartingFlights { get; set; }
            = new List<Flight>();
        public ICollection<Flight> ArrivingFlights { get; set; }
            = new List<Flight>();
    }
}
