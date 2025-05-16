using Microsoft.EntityFrameworkCore;
using TrainingStudio.Models;

namespace TrainingStudio.Contexts
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<ProgramModel> ProgramModels { get; set; }
    }
}
