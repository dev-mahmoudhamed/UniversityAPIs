using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    internal sealed class StudentService : IStudentService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public StudentService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public IEnumerable<StudentDTO> GetAllStudents(bool trackChanges)
        {
            
                var students = _repository.Student.GetAllStudents(trackChanges);
                var studentsDTO = _mapper.Map<IEnumerable<StudentDTO>>(students);
                return studentsDTO;
            
        }
    }
}