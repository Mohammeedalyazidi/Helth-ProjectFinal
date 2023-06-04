using Microsoft.EntityFrameworkCore;

namespace Helth_ProjectFinal.Models
{



    public class PedometerDbContext : DbContext
    {
        public PedometerDbContext(DbContextOptions<PedometerDbContext> options)
   : base(options) { }

        public DbSet<StepsModel> steps { get; set; }
    }
}
    
