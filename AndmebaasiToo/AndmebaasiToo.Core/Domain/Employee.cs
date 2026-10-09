using System.ComponentModel.DataAnnotations;


namespace AndmebaasiToo.Core.Domain
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string EmployeeNumber { get; set; }
        [MaxLength(20)]
        public string Telephone { get; set; }
        [MaxLength(100)]
        public string Position { get; set; }

        public Guid? TerminalId { get; set; }
        public Terminal Terminal { get; set; }

        public ICollection<FlightEmployee> FlightEmployees { get; set; }
            = new List<FlightEmployee>();
    }
}
