﻿namespace HamburgerAppMVC.Areas.Identity.Data.Entities.Abstract
{
    public interface IBase
    {
        public int Id { get; set; }

        public bool IsActive { get; set; }
    }
}
