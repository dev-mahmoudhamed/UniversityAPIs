using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Course
    {
        [Key]
        public string CourseCode { get; set; }

        [Required(ErrorMessage = "CourseName is a required field.")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "CourseInstractor is a required field.")]
        public string CourseInstractor { get; set; }

        [ForeignKey("DepartmentCode")]
        public Department Department { get; set; }
        public string DepartmentCode { get; set; }

    }
}