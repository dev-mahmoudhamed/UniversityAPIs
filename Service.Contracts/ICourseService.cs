using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface ICourseService
    {
        IEnumerable<CourseDTO> GetCourses(bool trackChanges);
    }
}
