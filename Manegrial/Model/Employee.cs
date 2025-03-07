using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manegrial.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? EmpName { get; set; }
        public int Salary { get; set; }
        [ForeignKey("Manager")]
        public int TeamId { get; set; }  
    }
}
