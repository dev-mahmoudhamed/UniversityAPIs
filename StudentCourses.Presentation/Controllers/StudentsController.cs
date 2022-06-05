using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
using Shared.RequestFeatures;

namespace StudentCourses.Presentation.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IServiceManager _service;
        public StudentsController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetStudents([FromQuery] StudentParameters stdParams)
        {
            // throw new Exception("Exception");
            var students = _service.StudentService.GetAllStudents( stdParams,trackChanges: false);
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(Guid id)
        {
            var student = _service.StudentService.GetStudent(id, trackChanges: false);
            return Ok(student);
        }

        [HttpPost]
        public IActionResult CreateStudent(StudentDTO student)
        {
            var createdStudent = _service.StudentService.CreateStudent(student);
            return Ok(createdStudent);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(Guid id)
        {
            _service.StudentService.DeleteStudent(id, trackChanges: false);
            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(Guid id, StudentDTO studentForUpdate)
        {
            _service.StudentService.UpdateStudent(id, studentForUpdate, TrackChanges: true);
            return NoContent();
        }
    }
}
