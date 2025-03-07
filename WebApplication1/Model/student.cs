using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication1.Controllers.Model
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        // Static list of students
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "John Doe" },
            new Student { Id = 2, Name = "Jane Smith" }
        };

        // Updated endpoint that accepts roll number and name as parameters
        [HttpGet("{rollNumber}/{name}")]
        public ActionResult<Student> GetStudent(int rollNumber, string name)
        {
            // Search for the student using roll number and case-insensitive name comparison
            var student = students.FirstOrDefault(s => s.Id == rollNumber && s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            // If student is not found, return a Not Found (404) response
            if (student == null)
            {
                return NotFound(new { Message = "Student not found" });
            }

            // If student is found, return the student with an OK (200) response
            return Ok(student);
        }
    }

    // Student model class
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}