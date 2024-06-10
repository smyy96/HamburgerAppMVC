using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HamburgerAppMVC.Migrations
{
    /// <inheritdoc />
    public partial class menuCRUD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "031A45EF-18ED-4BBC-80E5-D0E6FE65908C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a952ad53-e444-41a3-ad0a-2a4ac289ffdf", "670cb125-5900-4680-afe2-218537c8dba8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66A51954-D206-4000-9F81-F73FE061B52D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b672789c-41dc-4e0a-b18e-b25751c9e41b", "07f1ae93-95e1-4389-b372-15b1fbd4868c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "031A45EF-18ED-4BBC-80E5-D0E6FE65908C",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5723ed2e-ae22-43d2-beb6-16337b845b62", "fb1edd8a-f2e6-4f98-9db9-d12f97d8e03e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66A51954-D206-4000-9F81-F73FE061B52D",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "880d87eb-42c7-4c41-9a7b-d6d9bb078e4e", "726a00fa-c7aa-43a7-a8f9-a9500bc02f30" });
        }
    }
}
