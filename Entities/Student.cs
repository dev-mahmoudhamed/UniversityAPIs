namespace UniversityAPI.Entities
{
    public class Student
    {
        public Guid StudentID { get; set; }
        public string StudentName { get; set; }
        public float GPA { get; set; }
        public Department Department { get; set; }

        public IEnumerable<Course> RegisteredCourses { get; set; }

    }
}
