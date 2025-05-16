using CharityMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CharityMVC.Contexts
{
    public class AppDbContext : DbContext
    {
        private readonly string _connetionstring = @"Server=DESKTOP-GTVND9D\SQLEXPRESS;Database=CharityDB;Trusted_Connection=True;TrustServerCertificate=True";

        public DbSet<CausesModel> CausesModels { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connetionstring);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
