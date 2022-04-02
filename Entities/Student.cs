namespace UniversityAPI.Entities
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public float GPA { get; set; }
        public string DepartmentCode { get; set; }
        public IEnumerable<Course> RegisteredCourses { get; set; }

    }
}
