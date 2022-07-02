using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace StudentCourses.Presentation_.Controllers
{
    [ApiController]
    [Route("api/courses")]
    public class CoursesController : ControllerBase
    {
        private readonly IServiceManager _service;
        public CoursesController(IServiceManager service) => _service = service;

        [HttpGet]
        public IActionResult GetCourses()
        {
            var courses = _service.CourseService.GetCourses(trackChanges: false);
            return Ok(courses);
        }
    }
}
