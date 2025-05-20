using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carvilla.DAL.Models
{
    public class CarsModel:BaseModel
    {
       public string Name { get; set; }
       public string? Description { get; set; }
       public string? Imgurl { get; set; }
       public string Model { get; set; }
       public string Mi { get; set; }
       public string HP { get; set; }
       public int Price { get; set; }
    }
}
