using System.ComponentModel.DataAnnotations;


namespace AndmebaasiToo.Core.Domain
{
    public class FlightEmployee
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(50)]
        public string Role { get; set; }

        public Guid FlightId { get; set; }
        public Flight Flight { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
