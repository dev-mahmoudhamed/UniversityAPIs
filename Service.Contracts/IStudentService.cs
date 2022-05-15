using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IStudentService
    {
        IEnumerable<StudentDTO> GetAllStudents(bool trackChanges);
        StudentDTO GetStudent(Guid studentId, bool trackChanges);

        StudentDTO CreateStudent(StudentDTO student);
    }
}