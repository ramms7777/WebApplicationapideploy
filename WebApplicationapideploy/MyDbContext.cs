using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    // Example: Define your table
    public DbSet<MyTable> MyTables { get; set; }
}

// Example model class
public class MyTable
{
    public int Id { get; set; }
    public required string Name { get; set; }
}
