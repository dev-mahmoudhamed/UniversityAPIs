
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Department
    {
        [Key]
        [Required(ErrorMessage = "DepartmentCode is a required field.")]
        public string DepartmentCode { get; set; }

        [Required(ErrorMessage = "DepartmentName is a required field.")]
        public string DepartmentName { get; set; }

        [Required(ErrorMessage = "DepartmentHead is a required field.")]
        public string DepartmentHead { get; set; }
        public IEnumerable<Course> DepartmentCourses { get; set; }

    }
}