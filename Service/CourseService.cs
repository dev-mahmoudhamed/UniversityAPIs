using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    internal sealed class CourseService : ICourseService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public CourseService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;

        }
        public IEnumerable<CourseDTO> GetCourses(bool trackChanges)
        {
            var courses = _repository.Course.GetCourses(trackChanges);
            var coursesDto = _mapper.Map<IEnumerable<CourseDTO>>(courses);
            return coursesDto;
        }
    }
}