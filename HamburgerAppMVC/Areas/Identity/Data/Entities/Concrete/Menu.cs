using HamburgerAppMVC.Areas.Identity.Data.Entities.Abstract;

namespace HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete
{
    public class Menu : Base
    {
        public string MenuName { get; set; }

        public double Price { get; set; }

        public string Picture { get; set; }

        public string Description { get; set; }
    }
}
