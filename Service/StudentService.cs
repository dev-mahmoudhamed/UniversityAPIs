using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
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

        public StudentDTO CreateStudent(StudentDTO student)
        {
            var studentEntity = _mapper.Map<Student>(student);
            _repository.Student.createStudent(studentEntity);
            _repository.SaveAsync();
            var studentToReturn = _mapper.Map<StudentDTO>(studentEntity);
            return studentToReturn;
        }

        public void DeleteStudent(Guid studentId, bool trackChanges)
        {
            var student = _repository.Student.GetStudent(studentId, trackChanges);
            _repository.Student.DeleteStudent(student);
            _repository.SaveAsync();
        }

        public IEnumerable<StudentDTO> GetAllStudents(bool trackChanges)
        {

            var students = _repository.Student.GetAllStudents(trackChanges);
            var studentsDTO = _mapper.Map<IEnumerable<StudentDTO>>(students);
            return studentsDTO;

        }

        public StudentDTO GetStudent(Guid studentId, bool trackChanges)
        {
            var student = _repository.Student.GetStudent(studentId, trackChanges);
            if (student is null)
            {
                throw new StudentNotFoundException(studentId);
            }
            var studentDto = _mapper.Map<StudentDTO>(student);
            return studentDto;
        }

        public void UpdateStudent(Guid id, StudentDTO studentForUpdate, bool TrackChanges)
        {
            var oldStudent = _repository.Student.GetStudent(id, TrackChanges);
            _mapper.Map(studentForUpdate, oldStudent);
            _repository.SaveAsync();
        }
    }
}