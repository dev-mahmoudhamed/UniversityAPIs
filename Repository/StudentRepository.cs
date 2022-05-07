using Contracts;
using Entities.Models;

namespace Repository
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Student> GetAllStudents(bool trackChanges) =>
        FindAll(trackChanges).OrderBy(std => std.StudentName).ToList();
    }
}
