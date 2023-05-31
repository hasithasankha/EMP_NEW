using System.ComponentModel.DataAnnotations;

namespace EMP_NEW.Data
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        //Department department { get; set; }

    }
}
