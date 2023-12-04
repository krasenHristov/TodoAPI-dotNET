using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{

    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> todoitems { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>()
                .Property(e => e.id)
                .UseSerialColumn();
        }

    }
}
