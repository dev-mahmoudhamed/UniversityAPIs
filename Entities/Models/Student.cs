using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Student
    {
        public Guid StudentID { get; set; }

        [Required(ErrorMessage = "Student name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the student name is 60 characters.")]
        public string StudentName { get; set; }
        public float GPA { get; set; }

        public string DepartmentCode { get; set; }
        public IEnumerable<Course> RegisteredCourses { get; set; }
    }
}
