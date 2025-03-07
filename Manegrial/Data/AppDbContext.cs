using Microsoft.EntityFrameworkCore;
using Manegrial.Model;

namespace Manegrial.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
