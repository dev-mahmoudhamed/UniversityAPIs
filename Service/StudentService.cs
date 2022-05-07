using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    internal sealed class StudentService : IStudentService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        public StudentService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IEnumerable<StudentDto> GetAllStudents(bool trackChanges)
        {
            try
            {
                var students = _repository.Student.GetAllStudents(trackChanges);
                var studentsDto = students.Select(std => 
                    new StudentDto (std.StudentID, std.StudentName, std.GPA, std.DepartmentCode)).ToList();
                return studentsDto;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong in the {nameof(GetAllStudents)} service method { ex}");
                throw;
            }
        }
    }
}