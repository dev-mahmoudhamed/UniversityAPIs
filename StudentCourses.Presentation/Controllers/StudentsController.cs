using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace StudentCourses.Presentation.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IServiceManager _service;
        public StudentsController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetStudents()
        {
           // throw new Exception("Exception");
            var students = _service.StudentService.GetAllStudents(trackChanges: false);
            return Ok(students);
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetStudent(Guid id)
        {
            var student = _service.StudentService.GetStudent(id, trackChanges : false);
            return Ok(student);
        }

        [HttpPost] 
        public IActionResult CreateStudent(StudentDTO student)
        {
            var createdStudent = _service.StudentService.CreateStudent(student);
            return Ok(createdStudent);
        }
    }
}
