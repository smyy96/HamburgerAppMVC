using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HamburgerAppMVC.Areas.Identity.Data.EntityConfigurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {

                    Id = "66A51954-D206-4000-9F81-F73FE061B52D",
                    Name = "Kullanici Name",
                    Surname = "Kullanici Surname",
                    UserName = "kullanici@gmail.com",
                    NormalizedUserName = "KULLANICI@GMAIL.COM",
                    Email = "kullanici@gmail.com",
                    NormalizedEmail = "KULLANICI@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAIAAYagAAAAEPxaUcQBXHjUxxAfHVSITSYFV7tkSgf4S1YEeppkOo0al0WcB7QNhp7YKFJzZMTN+Q==",//Sifre: Aa123456.
                    LockoutEnabled = true,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false

                },
                new User
                {
                    Id = "031A45EF-18ED-4BBC-80E5-D0E6FE65908C",
                    Name = "Admin",
                    Surname = "Admin",
                    UserName = "admin@gmail.com",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    EmailConfirmed = true,
                    PasswordHash = "AQAAAAIAAYagAAAAEPxaUcQBXHjUxxAfHVSITSYFV7tkSgf4S1YEeppkOo0al0WcB7QNhp7YKFJzZMTN+Q==",// Sifre: Aa123456.
                    LockoutEnabled = true,
                    TwoFactorEnabled = false,
                    PhoneNumberConfirmed = false
                }
                );
        }
    }
}
