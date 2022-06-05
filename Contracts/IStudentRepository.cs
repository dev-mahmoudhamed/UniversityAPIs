using Entities.Models;

namespace Contracts
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents(bool trackChanges);
        Student GetStudent(Guid studentId, bool trackChanges);
        void createStudent (Student student);
        void DeleteStudent(Student student);
    }
}
