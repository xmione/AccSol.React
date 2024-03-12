using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccSol.React.Entities.Models
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "EmployeeNumber is required")]
        public string? EmployeeNumber { get; set; }
        [Required(ErrorMessage = "FirstName is required")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "MiddleName is required")]
        public string? MiddleName { get; set; }
        [Required(ErrorMessage = "LastName is required")]
        public string? LastName { get; set; }
        [ForeignKey("DepartmentID")]
        public int? DepartmentID { get; set; }
        public Department? Department { get; set; }
    }
}
