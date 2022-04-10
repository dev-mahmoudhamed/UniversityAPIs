using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityAPI.Entities
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public float GPA { get; set; }
        public string DepartmentCode { get; set; }
        [NotMapped]
        public IEnumerable<Course> RegisteredCourses { get; set; }

    }
}
