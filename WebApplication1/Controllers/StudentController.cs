using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers.Model;
namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class StudentController : Controller
    {
        public static List<Student> students = new List<Student>();
        public static List<Account> accounts = new List<Account>();

        [HttpGet]
        public List<Student> GetStudents()
        {
            return students;
        }
        [HttpGet("{id}")]
        
        public Student GetStudent(int id)
        {

            return students.Find(s => s.Id == id);
        }
        [HttpPost]
        public string AddStudent(Student student)
        {
            students.Add(student);
            return $"Student {student.Name} added successfully";
        }

        //[HttpPost]
        //public string AddAccount(Account account)
        //{
        //    accounts.Add(account);
        //    return $"Account {account.id} added successfully";
        //}
        [HttpPut]
        public string UpdateStudent(Student student)
        {
           Student studentToUpdate = students.Find(s => s.Id == student.Id);
            studentToUpdate.Name = student.Name;
            return $"Student {student.Name} updated successfully";

        }   
        [HttpDelete]
        public string DeleteStudent(int id)
        {
            var existingStudent = students.FirstOrDefault(s => s.Id == id);
            if (existingStudent != null)
            {
                students.Remove(existingStudent);
                return $"Student {existingStudent.Name} deleted successfully";
            }
            return $"Student not found";
        }
    }
} 