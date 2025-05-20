using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carvilla.BL.ViewModels
{
    public class CarsModelUpdateVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
       
        public IFormFile? Image { get; set; }
        public string Model { get; set; }
        public string Mi { get; set; }
        public string HP { get; set; }
        public int Price { get; set; }
    }
}
