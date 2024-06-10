using HamburgerAppMVC.Areas.Identity.Data.Entities.Abstract;

namespace HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete
{
    public class ExtraMaterial : Base
    {

        public string ExtraMaterialName { get; set; }

        public double Price { get; set; }

        public string Picture { get; set; }



        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

}
