using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Department
    {
        [Key]
        [Required(ErrorMessage = "Department Code is a required field.")]
        public string DepartmentCode { get; set; }

        [Required(ErrorMessage = "Department Name is a required field.")]
        public string DepartmentName { get; set; }

        [Required(ErrorMessage = "Department Head is a required field.")]
        public string DepartmentHead { get; set; }

    }
}