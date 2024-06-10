namespace HamburgerAppMVC.Areas.Identity.Data.Entities.Abstract
{
    public abstract class Base : IBase
    {
        public int Id { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
