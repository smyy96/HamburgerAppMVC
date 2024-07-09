namespace HamburgerAppMVC.Models
{
    public class ExtraMaterialViewModel
    {
        public string ExtraMaterialName { get; set; }
        public double Price { get; set; }
        public IFormFile Image { get; set; }

        public int CategoryId { get; set; }
    }
}
