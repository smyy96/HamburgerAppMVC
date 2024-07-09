using HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HamburgerAppMVC.Areas.Identity.Data.EntityConfigurations
{
    public class MenuConfig : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasData(
                new Menu
                {
                    Id = 1,
                    MenuName = "Whopper",
                    Price = 190,
                    PictureName = "whopper_90d608faab.jpg",
                    Description = "Whopper eti (dana), 5'' ekmek, turşu, ketçap, mayonez, göbek salata, domates, soğan",
                    IsActive = true
                },

                new Menu
                {
                    Id = 2,
                    MenuName = "Etli Barbekü Brioche Menü",
                    Price = 195,
                    PictureName = "etli_barbeku_brioche_menu_187fd3fb30_84eaff0f97.jpg",
                    Description = "Etli Barbekü Brioche® + Patates Kızartması (Orta) + Kutu İçecek",
                    IsActive = true
                },

                new Menu
                {
                    Id = 3,
                    MenuName = "3''lü Whopper Fırsatı",
                    Price = 330,
                    PictureName = "3lu_whopper_firsati_b77b9c5a7e.jpg",
                    Description = "3 Adet Whopper Jr. + Patates Kızartması (Büyük) + 1L. İçecek",
                    IsActive = true
                },

                new Menu
                {
                    Id = 4,
                    MenuName = "Kral İkili Menü",
                    Price = 270,
                    PictureName = "kral_ikili_a68fca6955.jpg",
                    Description = "Big King + King Chicken + Patates Kızartması (Orta) + 1L İçecek",
                    IsActive = true
                },

                new Menu
                {
                    Id = 5,
                    MenuName = "2''li Big King",
                    Price = 365,
                    PictureName = "2li_big_king_firsati_f8f3a3eaae.jpg",
                    Description = "Big King + Big King + Patates Kızartması (Orta) + 1L. İçecek",
                    IsActive = true
                },

                new Menu
                {
                    Id = 6,
                    MenuName = "Steakhouse Burger",
                    Price = 250,
                    PictureName = "bk_steakhouse_burger_ff2d3a53c9.jpg",
                    Description = "Baharatlı Steak Köftesi, 4,5'' ekmek, mayonez, domates, göbek salata, 2 dilim peynir, özel steak sos, çıtır soğan",
                    IsActive = true
                },

                new Menu
                {
                    Id = 7,
                    MenuName = "Texas Smokehouse Burger",
                    Price = 265,
                    PictureName = "texas_smokehouse_burger_bbaf4383e6.jpg",
                    Description = "Texas Smokehouse Burger, Whopper eti (dana), 4,5” ekmek, 2 dilim cheddar peyniri, füme kaburga et, barbekü sos, çıtır soğan",
                    IsActive = true
                }
                );
        }

    }
}
