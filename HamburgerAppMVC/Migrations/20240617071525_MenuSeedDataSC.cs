using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HamburgerAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class MenuSeedDataSC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "031A45EF-18ED-4BBC-80E5-D0E6FE65908C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fa51b96f-b393-4cd5-9eaa-c88f8a369586", "ca9b060a-587d-4770-a75d-146118d471cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66A51954-D206-4000-9F81-F73FE061B52D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "98b31f38-9c7e-4792-8cf8-93ae75e6bc9b", "a820657d-2c5e-47a2-b13c-3e60f108824e" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "MenuName", "PictureName", "Price" },
                values: new object[] { "Whopper eti (dana), 5'' ekmek, turşu, ketçap, mayonez, göbek salata, domates, soğan", "Whopper", "whopper_90d608faab.jpg", 190.0 });



            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Description", "IsActive", "MenuName", "PictureName", "Price" },
                values: new object[,]
                {
                    { 1,"Whopper eti (dana), 5'' ekmek, turşu, ketçap, mayonez, göbek salata, domates, soğan", true, "Whopper", "whopper_90d608faab.jpg", 190.0 },
                    { 2, "Etli Barbekü Brioche® + Patates Kızartması (Orta) + Kutu İçecek",true, "Etli Barbekü Brioche Menü", "etli_barbeku_brioche_menu_187fd3fb30_84eaff0f97.jpg", 195.0 },
                    { 3,"3 Adet Whopper Jr. + Patates Kızartması (Büyük) + 1L. İçecek",true, "3''lü Whopper Fırsatı", "3lu_whopper_firsati_b77b9c5a7e.jpg", 330.0 },
                    { 4, "Big King + King Chicken + Patates Kızartması (Orta) + 1L İçecek", true, "Kral İkili Menü", "kral_ikili_a68fca6955.jpg", 270.0 },
                    { 5, "Big King + Big King + Patates Kızartması (Orta) + 1L. İçecek", true, "2''li Big King", "2li_big_king_firsati_f8f3a3eaae.jpg", 365.0 },
                    { 6, "Baharatlı Steak Köftesi, 4,5'' ekmek, mayonez, domates, göbek salata, 2 dilim peynir, özel steak sos, çıtır soğan", true, "Steakhouse Burger", "bk_steakhouse_burger_ff2d3a53c9.jpg", 250.0 },
                    { 7, "Texas Smokehouse Burger, Whopper eti (dana), 4,5” ekmek, 2 dilim cheddar peyniri, füme kaburga et, barbekü sos, çıtır soğan", true, "Texas Smokehouse Burger", "texas_smokehouse_burger_bbaf4383e6.jpg", 265.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "031A45EF-18ED-4BBC-80E5-D0E6FE65908C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3676616d-674a-4096-b52e-35e8e62264ab", "cc59c995-3246-4433-890e-b4f13f1418f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66A51954-D206-4000-9F81-F73FE061B52D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "72ea2a3b-3040-42e3-b20d-f9429f3eebea", "0f47f277-13b9-468e-9974-b5530a3d20a0" });
        }
    }
}
