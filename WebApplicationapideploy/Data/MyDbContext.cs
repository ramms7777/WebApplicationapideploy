using Microsoft.EntityFrameworkCore;
using WebApplicationapideploy.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // Add your tables (entities) as DbSet<T> properties
    public DbSet<Employee> Employees { get; set; }  // Example
}
