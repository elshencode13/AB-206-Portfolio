using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Contexts
{
    public class AppDbContext : DbContext
    {
        private readonly string _connectionString = "Server=BAABAAA;Database=FiorelloDb;Trusted_Connection=True;TrustServerCertificate=True";

        public DbSet<TredingGame> TredingGames { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
