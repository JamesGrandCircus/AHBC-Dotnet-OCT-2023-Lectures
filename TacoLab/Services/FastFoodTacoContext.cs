using Microsoft.EntityFrameworkCore;
using TacoLab.Models;

namespace TacoLab.Services
{
    public class FastFoodTacoContext : DbContext
    {
        //                                                  in javascript
        //                                                  this would be called super()
        public FastFoodTacoContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Taco> Taco { get; set; }
        public DbSet<Drink> Drink { get; set; }
    }
}
