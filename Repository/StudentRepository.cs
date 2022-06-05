using Contracts;
using Entities.Models;
using Shared.RequestFeatures;

namespace Repository
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void createStudent(Student student) => Create(student);

        public void DeleteStudent(Student student) => Delete(student);

        public IEnumerable<Student> GetAllStudents(StudentParameters stdParams, bool trackChanges) =>
        FindAll(trackChanges).OrderBy(std => std.StudentName)
            .Skip((stdParams.PageNumber -1) * stdParams.PageSize)
            .Take(stdParams.PageSize)
            .ToList();

        public Student GetStudent(Guid studentId, bool trackChanges) =>
            FindByCondition(std => std.StudentID.Equals(studentId), trackChanges).SingleOrDefault();
    }
}
