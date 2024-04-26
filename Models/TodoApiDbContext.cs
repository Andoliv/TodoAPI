using Microsoft.EntityFrameworkCore;

namespace TodoAPI.Models;

public class TodoApiDbContext : DbContext
{
    public TodoApiDbContext(DbContextOptions<TodoApiDbContext> options) : base(options) { }

    public DbSet<Todo> Todos { get; set; } = null!;

    public DbSet<User> Users { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todo>()
            .Property(prop => prop.Item)
            .HasMaxLength(256);

        base.OnModelCreating(modelBuilder);
    }
}
