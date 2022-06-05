using Shared.DataTransferObjects;
using Shared.RequestFeatures;

namespace Service.Contracts
{
    public interface IStudentService
    {
        IEnumerable<StudentDTO> GetAllStudents(StudentParameters stdParams , bool trackChanges);
        StudentDTO GetStudent(Guid studentId, bool trackChanges);
        StudentDTO CreateStudent(StudentDTO student);
        void DeleteStudent(Guid studentId, bool trackChanges);
        void UpdateStudent(Guid id, StudentDTO studentForUpdate, bool TrackChanges);
    }
}