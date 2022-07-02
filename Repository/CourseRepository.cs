using Contracts;
using Entities.Models;

namespace Repository
{
    public class CourseRepository : RepositoryBase<Course>, ICourseRepository
    {
        public CourseRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
        public IEnumerable<Course> GetCourses(bool trackChanges) => FindAll(trackChanges).ToList();
     
    }
}
