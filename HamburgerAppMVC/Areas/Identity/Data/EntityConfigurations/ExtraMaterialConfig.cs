using HamburgerAppMVC.Areas.Identity.Data.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HamburgerAppMVC.Areas.Identity.Data.EntityConfigurations
{
    public class ExtraMaterialConfig : IEntityTypeConfiguration<ExtraMaterial>
    {
        public void Configure(EntityTypeBuilder<ExtraMaterial> builder)
        {
            builder.HasData(
                new ExtraMaterial
                {
                    Id = 1,
                    ExtraMaterialName = "Coca - Cola Zero Sugar",
                    Price = 35,
                    PictureName = "coca_cola_zero_sugar_33_cl_baf77227e6.jpg",
                    CategoryId = 1
                },
                new ExtraMaterial
                {
                    Id = 2,
                    ExtraMaterialName = "Berry Hibiscus",
                    Price = 50,
                    PictureName = "bk_berry_hibiscus_a1140aad64.jpg",
                    CategoryId = 1
                },
                new ExtraMaterial
                {
                    Id = 3,
                    ExtraMaterialName = "Muffin",
                    Price = 20,
                    PictureName = "muffin_3b7b7511f1.jpg",
                    CategoryId = 2
                },
                new ExtraMaterial
                {
                    Id = 4,
                    ExtraMaterialName = "Çikolatalı Sufle",
                    Price = 50,
                    PictureName = "cikolatali_sufle_a142511990.jpg",
                    CategoryId = 2
                },
                new ExtraMaterial
                {
                    Id = 5,
                    ExtraMaterialName = "Ketçap",
                    Price = 5,
                    PictureName = "ketcap_32f8f33054.jpg",
                    CategoryId = 4
                },
                new ExtraMaterial
                {
                    Id = 6,
                    ExtraMaterialName = "Çıtır Çıtır Atıştır",
                    Price = 60,
                    PictureName = "citir_citir_atistir_d0153d6c4e.jpg",
                    CategoryId = 5
                },
                new ExtraMaterial
                {
                    Id = 7,
                    ExtraMaterialName = "Buffalo Sos",
                    Price = 6,
                    PictureName = "buffalo_sos_83b747af5c.jpg",
                    CategoryId = 4
                }
                );
        }
    }
}
