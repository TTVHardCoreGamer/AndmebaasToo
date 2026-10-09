using System.ComponentModel.DataAnnotations;


namespace AndmebaasiToo.Core.Domain
{
    public class Gate
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(10)]
        public string Number { get; set; }
        [MaxLength(100)]
        public string Location { get; set; }
        [MaxLength(50)]
        public string MaxAircraftSize { get; set; }

        public Guid TerminalId { get; set; }
        public Terminal Terminal { get; set; }

        public ICollection<Flight> Flights { get; set; }
            = new List<Flight>();
    }
}
