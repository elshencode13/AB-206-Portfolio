using Carvilla.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carvilla.DAL.Contexts;

public class AppDbContext:DbContext
{
    private readonly string _connectionString = @"Server=DESKTOP-GTVND9D\SQLEXPRESS;Database=CarvillaDb;Trusted_Connection=True;TrustServerCertificate=True";
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<CarsModel> CarsModels { get; set; }
}
