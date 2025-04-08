using Microsoft.EntityFrameworkCore;
using WebApplicationapideploy.Models;  // 👈 update this based on your project

namespace WebApplicationapideploy.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
