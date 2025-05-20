using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViIla.DAL.Contexts;

namespace VillaApp.BL.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
    }
}
