using System.ComponentModel.DataAnnotations;

namespace AccSol.React.Entities.Models
{
    public class Department
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "Code is required")]
        public string? Code { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }
    }
}
