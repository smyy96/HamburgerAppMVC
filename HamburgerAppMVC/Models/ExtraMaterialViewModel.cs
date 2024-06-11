namespace HamburgerAppMVC.Models
{
    public class ExtraMaterialViewModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public IFormFile Image { get; set; }

        public int CategoryId { get; set; }
    }
}
