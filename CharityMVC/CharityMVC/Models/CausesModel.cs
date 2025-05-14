namespace CharityMVC.Models
{
    public class CausesModel : BaseModel
    {
        public string Name { get; set; }
        public string Imgurl { get; set; }
        public string Description { get; set; }
        public double Raised { get; set; }
        public double Goal { get; set; }
    }
}
