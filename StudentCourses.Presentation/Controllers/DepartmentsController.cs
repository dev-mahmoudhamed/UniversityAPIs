using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace StudentCourses.Presentation_.Controllers
{
    [ApiController]
    [Route("api/departments")]
    public class DepartmentsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public DepartmentsController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetDepartments()
        {
            var departments = _service.DepartmentService.GetDepartments(trackChanges: false);
            return Ok(departments);
        }

        [HttpGet("{departmentCode}")]
        public IActionResult GetEmployeeForCompany(string departmentCode)
        {
            var department = _service.DepartmentService.GetDepartment(departmentCode, trackChanges: false);
            return Ok(department);
        }
    }
}
