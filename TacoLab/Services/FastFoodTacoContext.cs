using Microsoft.EntityFrameworkCore;
using TacoLab.Models;

namespace TacoLab.Services
{
    public class FastFoodTacoContext : DbContext
    {
        public FastFoodTacoContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Taco> Taco { get; set; }
        public DbSet<Drink> Drink { get; set; }
    }
}
