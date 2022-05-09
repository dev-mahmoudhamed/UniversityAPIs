using AutoMapper;
using Contracts;
using Service.Contracts;

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
}
}