using Microsoft.EntityFrameworkCore;

namespace WebApi.models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<emplyoyee> employees { get; set; }
    }
}
