using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IStudentService
    {
        IEnumerable<StudentDTO> GetAllStudents(bool trackChanges);

    }
}