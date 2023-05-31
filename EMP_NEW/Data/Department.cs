using System.ComponentModel.DataAnnotations;

namespace EMP_NEW.Data
{
    public class Department 
    {
        [Key]
        public int DepartmentId { get; set; }
        [Required]
        public string DepartmentName  { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

    
    }
}
