using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Pie> Pies { get; set; }
        public DbSet<Beer> Beers { get; set; }
    }
}
