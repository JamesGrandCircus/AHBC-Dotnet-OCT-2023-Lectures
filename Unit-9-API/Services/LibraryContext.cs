using Microsoft.EntityFrameworkCore;
using Unit_9_API.Models;

namespace Unit_9_API.Services
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options) // this options COnTAINS your CONNECTION STRING!
        {

        }

        // this property NAME SHOULD match your TABLE NAME
        public DbSet<Book> Books { get; set; }
    }
}
