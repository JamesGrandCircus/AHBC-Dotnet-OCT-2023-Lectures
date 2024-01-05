using Microsoft.EntityFrameworkCore;
using unit_7_Entity_Framework_DB_First.Models;

namespace unit_7_Entity_Framework_DB_First.Services
{
    // your context class IS your DATABSE
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        // DbSet properties are your DATABSE TABLES
        // the name of your DbSet Property SHOULD be named 1:1 with your
        // database Table
        public DbSet<Book> Books { get; set; } // PROPERTY!!! not attribute FRANK!
    }
}
