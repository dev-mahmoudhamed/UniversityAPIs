using Contracts;
using Entities.Models;

namespace Repository
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void createStudent(Student student) => Create(student);

        public IEnumerable<Student> GetAllStudents(bool trackChanges) =>
        FindAll(trackChanges).OrderBy(std => std.StudentName).ToList();

        public Student GetStudent(Guid studentId, bool trackChanges) =>
            FindByCondition(std => std.StudentID.Equals(studentId), trackChanges).SingleOrDefault();
    }
}
