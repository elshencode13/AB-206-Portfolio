using Microsoft.EntityFrameworkCore;
using NFT.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFT.DAL.Contexts;

 

public class AppDbContext : DbContext
{
    public DbSet<ProductModel> ProductModels { get; set; }
     public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }   
}






