using AutoMapper;
using Contracts;
using Entities.Exceptions;
using Entities.Models;
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
        public async Task<IEnumerable<DepartmentDTO>> GetDepartmentsAsync(bool trackChanges)
        {
            var departments = await _repository.Department.GetDepartmentsAsync(trackChanges);
            var departmentsDto = _mapper.Map<IEnumerable<DepartmentDTO>>(departments);
            return departmentsDto;
        }
        public async Task<DepartmentDTO> GetDepartmentAsync(string departmentCode, bool trackChanges)
        {
            var department = await _repository.Department.GetDepartmentAsync(departmentCode, trackChanges);
            if (department == null)
                throw new DepartmentNotFoundException(departmentCode);

            var departmentDto = _mapper.Map<DepartmentDTO>(department);
            return departmentDto;
        }

        public async Task<DepartmentDTO> CreateDepartmentAsync(DepartmentDTO department)
        {
            var departmentEntity = _mapper.Map<Department>(department);
            _repository.Department.CreateDepartment(departmentEntity);
           await _repository.SaveAsync();
            var departmentToReturn = _mapper.Map<DepartmentDTO>(departmentEntity);
            return departmentToReturn;
        }

        public async Task DeleteDepartmentAsync(string departmentId, bool trackChanges)
        {
            var department = await _repository.Department.GetDepartmentAsync(departmentId, trackChanges);
            _repository.Department.DeleteDepartment(department);
            await _repository.SaveAsync();
        }

        public async Task UpdateDepartmentAsync(string departmentId, DepartmentDTO newDepartment, bool trackChanges)
        {
            var departmentEntity = await _repository.Department.GetDepartmentAsync(departmentId, trackChanges);
            if (departmentEntity is null)
                throw new DepartmentNotFoundException(departmentId);

            _mapper.Map(newDepartment, departmentEntity);
            await _repository.SaveAsync();
        }
    }
}