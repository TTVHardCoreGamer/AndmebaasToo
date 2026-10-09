using System.ComponentModel.DataAnnotations;


namespace AndmebaasiToo.Core.Domain
{
    public class Terminal
    {
        [Key]
        public Guid Id { get; set; }
        public int Number { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Location { get; set; }

        public ICollection<Gate> Gates { get; set; }
            = new List<Gate>();
        public ICollection<Employee> Employees { get; set; }
            = new List<Employee>();
    }
}
