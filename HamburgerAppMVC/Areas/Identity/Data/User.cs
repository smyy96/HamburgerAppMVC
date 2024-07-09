﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace HamburgerAppMVC.Areas.Identity.Data;

// Add profile data for application users by adding properties to the User class
public class User : IdentityUser
{
    public string Name { get; set; }
    public string Surname { get; set; }

    public ICollection<Order> Orders { get; set; }
}

