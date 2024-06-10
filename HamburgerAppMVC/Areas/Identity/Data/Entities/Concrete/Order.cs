using HamburgerAppMVC.Areas.Identity.Data.Entities.Abstract;

namespace HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete
{
    public class Order : Base
    {

        public string UserId { get; set; }
        public User User { get; set; }

        public DateTime OrderDate { get; set; }
        public double Price { get; set; }

        public ICollection<ExtraDetail> ExtraDetails { get; set; }
        public ICollection<MenuDetail> MenuDetails { get; set; }
    }
}
