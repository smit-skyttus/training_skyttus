using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Employee1> Employees{ get; set; }
    }
}
