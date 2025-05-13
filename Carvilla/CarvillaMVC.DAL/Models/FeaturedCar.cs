namespace Carvilla.DAL.Models
{
    public class FeaturedCar: BaseModel
    {
        public string ImgUrl { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}
