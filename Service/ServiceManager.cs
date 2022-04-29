using Contracts;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IStudentService> _studentService;
        private readonly Lazy<ICourseService> _courseService;
        private readonly Lazy<IDepartmentService> _departmentService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _studentService = new Lazy<IStudentService>(() => new StudentService(repositoryManager, logger));
            _courseService = new Lazy<ICourseService>(() => new CourseService(repositoryManager, logger));
            _departmentService = new Lazy<IDepartmentService>(() => new DepartmentService(repositoryManager, logger));
        }

        public ICourseService CourseService => _courseService.Value;
        public IDepartmentService DepartmentService => _departmentService.Value;
        public IStudentService StudentService => _studentService.Value;

    }
}