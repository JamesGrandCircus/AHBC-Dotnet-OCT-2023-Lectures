using Microsoft.EntityFrameworkCore;
using Unit_7_Entity_Code_First.Models;

namespace Unit_7_Entity_Code_First.Services
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {   }

        public DbSet<Todo> Todos { get; set; }
    }
}
