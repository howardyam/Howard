using Microsoft.EntityFrameworkCore;



namespace NASH1.Models
{
    public class FoodDbContext : DbContext
    {

        public FoodDbContext(DbContextOptions options ):base(options)
        {

        }

        
        public DbSet<FoodOrder> FoodOrder1 { get; set; }
    }
}
