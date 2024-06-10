using HamburgerAppMVC.Areas.Identity.Data.Entities.Abstract;

namespace HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete
{
    public class ExtraDetail : Base
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ExtraMaterialId { get; set; }
        public ExtraMaterial ExtraMaterial { get; set; }

        public int Total { get; set; }
    }
}
