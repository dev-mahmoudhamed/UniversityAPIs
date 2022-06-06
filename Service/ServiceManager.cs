using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Service.Contracts;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IStudentService> _studentService;
        private readonly Lazy<ICourseService> _courseService;
        private readonly Lazy<IDepartmentService> _departmentService;
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper,
            UserManager<User> userManager, IConfiguration configuration)
        {
            _studentService = new Lazy<IStudentService>(() => new StudentService(repositoryManager, logger, mapper));
            _courseService = new Lazy<ICourseService>(() => new CourseService(repositoryManager, logger, mapper));
            _departmentService = new Lazy<IDepartmentService>(() => new DepartmentService(repositoryManager, logger, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper, userManager, configuration));
        }

        public ICourseService CourseService => _courseService.Value;
        public IDepartmentService DepartmentService => _departmentService.Value;
        public IStudentService StudentService => _studentService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;

    }
}