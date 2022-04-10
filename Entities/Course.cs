using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace UniversityAPI.Entities
{
    [Keyless]
    public class Course
    {
        public string CourseCode { get; set; }
        public string CourseName { get; set; }
        public string CourseInstractor { get; set; }
    }
}