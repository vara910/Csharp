using System.ComponentModel.DataAnnotations;

namespace Vara2.Model1
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; } 
        public int Price { get; set; }
    }

}
