using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace StudentCourses.Presentation_.Controllers
{
    [ApiController]
    [Route("api/departments")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public DepartmentsController(IServiceManager service) => _service = service;

        [HttpGet]
        [Authorize]

        public async Task<IActionResult> GetDepartments()
        {
            var departments =await _service.DepartmentService.GetDepartmentsAsync(trackChanges: false);
            return Ok(departments);
        }

        [HttpGet("{departmentCode}")]
        public async Task<IActionResult> GetEmployeeForCompany(string departmentCode)
        {
            var department = await _service.DepartmentService.GetDepartmentAsync(departmentCode, trackChanges: false);
            return Ok(department);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDepartment(DepartmentDTO department)
        {
            var createdDepartment =await _service.DepartmentService.CreateDepartmentAsync(department);
             return Ok(createdDepartment);
        }

        [HttpPut("{departmentCode}")]
        public async Task<IActionResult> UpdateDepartment(string departmentCode, DepartmentDTO department)
        {
            await _service.DepartmentService.UpdateDepartmentAsync(departmentCode, department, trackChanges: true);
            return NoContent();
        }

        [HttpDelete()]
        public async Task<IActionResult> DeleteDepartment(string departmentCode)
        {
            await _service.DepartmentService.DeleteDepartmentAsync(departmentCode, trackChanges: false);
            return NoContent();
        }
    }
}
