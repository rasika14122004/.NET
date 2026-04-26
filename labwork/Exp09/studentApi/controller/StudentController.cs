using Microsoft.AspNetCore.Mvc;
using StudentCRUDApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentCRUDApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        // In-memory data
        static List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "Rahul", Course = "AIML" },
            new Student { Id = 2, Name = "Priya", Course = "CS" }
        };

        //GET all students
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAll()
        {
            return Ok(students);
        }

        //GET student by ID
        [HttpGet("{id}")]
        public ActionResult<Student> GetById(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            return Ok(student);
        }

        //POST (Add student)
        [HttpPost]
        public ActionResult<Student> AddStudent(Student student)
        {
            students.Add(student);
            return Ok(student);
        }

        //PUT (Update student)
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            student.Name = updatedStudent.Name;
            student.Course = updatedStudent.Course;

            return Ok(student);
        }

        //DELETE student
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
                return NotFound();

            students.Remove(student);
            return Ok("Deleted Successfully");
        }
    }
}



// How to Run:
// 1.Open terminal in studentApi folder
// 2.dotnet clean
// 3.dotnet build
// 4.dotnet Run
// 5.on httpPort/browser add route as /api/student
