using Microsoft.AspNetCore.Mvc;
using UniversityAPI.Data;
using UniversityAPI.Entities;

namespace wepAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentsContext _Context;
        public StudentController(StudentsContext context)
        {
            _Context = context;
        }
        /**********************************************************************************************************/
        [HttpGet]
        public ActionResult<List<Student>> GetAll()
        {
            return Ok(_Context.Students.ToList());
        }

        /**********************************************************************************************************/
        [HttpGet("{id}")]
        public ActionResult<Student> Get(int id)
        {
            var student = _Context.Students.Find(id);
            if (student == null) return BadRequest("Couldn't find the student");

            return Ok(student);
        }

        /**********************************************************************************************************/
        [HttpPost]
        public ActionResult<List<Student>> AddStudent(Student requestStudent)
        {
            _Context.Students.Add(requestStudent);
            _Context.SaveChanges();
            return Ok(_Context.Students.ToList());
        }

        /**********************************************************************************************************/
        [HttpPut]
        public ActionResult<List<Student>> UpdateStudent(Student requestStudent)
        {
            var student = _Context.Students.Find(requestStudent.StudentID);
            if (student == null)
            {
                return BadRequest("Couldn't find the student");
            }
            else
            {
                student.StudentName = requestStudent.StudentName;
                student.GPA = requestStudent.GPA;
                student.DepartmentCode = requestStudent.DepartmentCode;
                student.RegisteredCourses = requestStudent.RegisteredCourses;
            }

            _Context.SaveChanges();
            return Ok(_Context.Students.ToList());
        }

        /**********************************************************************************************************/
        [HttpDelete("{id}")]
        public ActionResult<List<Student>> DeleteStudent(int id)
        {
            var student = _Context.Students.Find(id);
            if (student == null)
            {
                return BadRequest("Couldn't find the student");
            }
            else
            {
                _Context.Students.Remove(student);
            }
            _Context.SaveChanges();
            return Ok(_Context.Students.ToList());
        }

    }
}
