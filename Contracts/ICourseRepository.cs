using Entities.Models;

namespace Contracts
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses(bool trackChanges);
    }
}
