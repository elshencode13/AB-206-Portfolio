namespace NFT.MVC.ViewModels
{
    public class ProductModelVM
    {
        public string Name { get; set; }
        public int Count { get; set; }
        public string Category { get; set; }
        public IFormFile ImgPath { get; set; }
    }
}
