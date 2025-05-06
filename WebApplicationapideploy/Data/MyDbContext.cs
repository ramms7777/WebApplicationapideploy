using Microsoft.EntityFrameworkCore;
using WebApplicationapideploy.Models;

namespace WebApplicationapideploy.Data  // 👈 Add this line
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
