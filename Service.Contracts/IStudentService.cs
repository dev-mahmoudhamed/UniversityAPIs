using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IStudentService
    {
        IEnumerable<StudentDTO> GetAllStudents(bool trackChanges);
        StudentDTO GetStudent(Guid studentId, bool trackChanges);
        StudentDTO CreateStudent(StudentDTO student);
        void DeleteStudent(Guid studentId, bool trackChanges);
        void UpdateStudent(Guid id, StudentDTO studentForUpdate, bool TrackChanges);
    }
}