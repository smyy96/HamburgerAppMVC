namespace HamburgerAppMVC.Models
{
    public class MenuViewModel
    {
        public string MenuName { get; set; }

        public double Price { get; set; }

        public IFormFile? Picture {  get; set; }

        public string Description { get; set; }

    }
}
