using Microsoft.EntityFrameworkCore;
//using Vara2.Model;
using Vara2.Model1;


namespace Vara2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
