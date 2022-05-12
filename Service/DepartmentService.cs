using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    internal sealed class DepartmentService : IDepartmentService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public DepartmentService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        public IEnumerable<DepartmentDTO> GetDepartments(bool trackChanges)
        {
            var departments = _repository.Department.GetDepartments(trackChanges);            
            var departmentsDto = _mapper.Map<IEnumerable<DepartmentDTO>>(departments);
            return departmentsDto;
        }
        public DepartmentDTO GetDepartment(string departmentCode, bool trackChanges)
        {
            var department = _repository.Department.GetDepartment(departmentCode, trackChanges);
            if (department == null)
                throw new DepartmentNotFoundException(departmentCode);

            var departmentDto = _mapper.Map<DepartmentDTO>(department);
            return departmentDto;
        }


    }
}