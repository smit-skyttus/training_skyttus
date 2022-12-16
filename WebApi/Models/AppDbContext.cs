using Microsoft.EntityFrameworkCore;

namespace WebApi.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options)
            : base (options)
        {

        }
    }
}
