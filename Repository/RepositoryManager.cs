using Contracts;

namespace Repository
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<ICourseRepository> _courseRepository;
        private readonly Lazy<IStudentRepository> _studentRepository;
        private readonly Lazy<IDepartmentRepository> _departmentRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _courseRepository = new Lazy<ICourseRepository>(() => new CourseRepository(repositoryContext));
            _studentRepository = new Lazy<IStudentRepository>(() => new StudentRepository(repositoryContext));
            _departmentRepository = new Lazy<IDepartmentRepository>(() => new DepartmentRepository(repositoryContext));

        }

        public ICourseRepository Course => _courseRepository.Value;
        public IStudentRepository Student => _studentRepository.Value;
        public IDepartmentRepository Department => _departmentRepository.Value;
        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
