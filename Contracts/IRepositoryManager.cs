
namespace Contracts
{
    public interface IRepositoryManager
    {
        ICourseRepository Course { get; }
        IStudentRepository Student { get; }
        IDepartmentRepository Department { get; }
        Task SaveAsync();
    }
}
