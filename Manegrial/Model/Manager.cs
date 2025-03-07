using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Manegrial.Model
{
    public class Manager
    {
        [Key]
        public int Id{ get; set; }
        public string? Name { get; set; }
        public virtual int TeamId { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
