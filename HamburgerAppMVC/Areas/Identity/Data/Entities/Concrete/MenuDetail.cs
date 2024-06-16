using HamburgerAppMVC.Areas.Identity.Data.Entities.Abstract;
using HamburgerAppMVC.Areas.Identity.Data.Entities.Enums;

namespace HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete
{
    public class MenuDetail : Base
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }


        public int MenuId { get; set; }
        public Menu Menu { get; set; }



        public int Total { get; set; }

        public SizeMenu Size { get; set; } = (SizeMenu)new Random().Next(1, 4);
    }
}
