using Entities.Models;
using Shared.RequestFeatures;

namespace Contracts
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents(StudentParameters stdParameters, bool trackChanges);
        Student GetStudent(Guid studentId, bool trackChanges);
        void createStudent (Student student);
        void DeleteStudent(Student student);
    }
}
