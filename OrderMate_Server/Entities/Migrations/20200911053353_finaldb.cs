using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class finaldb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          /*  migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e098760e-864e-4430-a05e-930015672101");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0728dde-0ad4-4120-b16a-eb965e7d128b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7f8b8f8-f01c-4d2e-a565-0bc3e527989e", "dddfe7a2-4db3-4d61-a6f6-80bdc592e419", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f9a1d46b-d070-4121-9f8b-7fab5816179d", "8c0d9016-6c1f-4edf-b273-ee4690cbf6f4", "Administrator", "ADMINISTRATOR" });
       */ }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7f8b8f8-f01c-4d2e-a565-0bc3e527989e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9a1d46b-d070-4121-9f8b-7fab5816179d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0728dde-0ad4-4120-b16a-eb965e7d128b", "376f35d4-b780-4c6b-ba22-b50befc0e290", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e098760e-864e-4430-a05e-930015672101", "1bdb0c32-1bd3-47ce-b717-1bdebcb830dc", "Administrator", "ADMINISTRATOR" });
        }
    }
}
