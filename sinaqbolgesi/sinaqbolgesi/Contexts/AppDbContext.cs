using Microsoft.EntityFrameworkCore;
using sinaqbolgesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinaqbolgesi.Contexts
{
    //1. Context folder daxilinde context class yaradilir.
    //2. Yaranmis context class dbcontext miras alir.
    //3. DBContext class-in gorunmesi ucun
    //Microsoft.EntityFrameworkCore NuGet Package yuklenmelidir
    //4. Yaranmis olan Context class daxiline hansi Database Provider-a  baglanacaqsa,
    //onun Microsoft.EntityFrameworkCore.sqlserver Provider Package yuklenmelidir.
    public class AppDbContext : DbContext
    {
        private readonly string _connectionString = "Server=<ServerName>;Database=<DatabaseName>;Trusted_Connection = True;TrustServerCertificate = True;";

        public DbSet<Meals> Meals { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer();
            base.OnConfiguring(optionsBuilder);
        }
    }
}
