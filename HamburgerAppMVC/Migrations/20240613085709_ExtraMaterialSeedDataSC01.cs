using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HamburgerAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class ExtraMaterialSeedDataSC01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "031A45EF-18ED-4BBC-80E5-D0E6FE65908C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9ea54aea-5071-4de7-9ff7-142a27a3764a", "613de9ce-57e3-43fe-af79-39a65714a5d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66A51954-D206-4000-9F81-F73FE061B52D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "645469f3-8e32-4ce1-a0ec-2f99c2393599", "17cca19e-3e4c-4e27-bf91-b6972db0a62a" });

            migrationBuilder.InsertData(
                table: "ExtraMaterials",
                columns: new[] { "Id", "CategoryId", "ExtraMaterialName", "IsActive", "PictureName", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Coca - Cola Zero Sugar", true, "coca_cola_zero_sugar_33_cl_baf77227e6.jpg", 35.0 },
                    { 2, 1, "Berry Hibiscus", true, "bk_berry_hibiscus_a1140aad64.jpg", 50.0 },
                    { 3, 2, "Muffin", true, "muffin_3b7b7511f1.jpg", 20.0 },
                    { 4, 2, "Çikolatalı Sufle", true, "cikolatali_sufle_a142511990.jpg", 50.0 },
                    { 5, 4, "Ketçap", true, "ketcap_32f8f33054.jpg", 5.0 },
                    { 6, 5, "Çıtır Çıtır Atıştır", true, "citir_citir_atistir_d0153d6c4e.jpg", 60.0 },
                    { 7, 4, "Buffalo Sos", true, "buffalo_sos_83b747af5c.jpg", 6.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExtraMaterials",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "031A45EF-18ED-4BBC-80E5-D0E6FE65908C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "736532d9-91b4-45dd-8461-ec33e6349e26", "b5641354-f720-4ad2-babf-1bedc6b17d4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66A51954-D206-4000-9F81-F73FE061B52D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "491f85e5-f409-4591-aa71-ec01e1360800", "0aaaa25e-b05f-4468-aad4-0359fb87ff9e" });
        }
    }
}
