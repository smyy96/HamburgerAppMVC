using HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete;

namespace HamburgerAppMVC.Models
{
    public class BasketViewModel
    {
        public List<Menu> MenuBasketList { get; set; }
        public List<ExtraMaterial> ExtraMaterialBasketList { get; set; }


        public Dictionary<int, int> MenuItemQuantities { get; set; } // Menu id ve miktarlarını tutuyor
        public Dictionary<int, int> ExtraMaterialItemQuantities { get; set; } // ExtraMaterial id ve miktarlarını tutuyor

        public BasketViewModel()
        {
            MenuBasketList = new List<Menu>();
            ExtraMaterialBasketList = new List<ExtraMaterial>();

            MenuItemQuantities = new Dictionary<int, int>();
            ExtraMaterialItemQuantities = new Dictionary<int, int>();
        }
    }
}
