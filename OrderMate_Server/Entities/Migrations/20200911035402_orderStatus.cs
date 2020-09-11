using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class orderStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Status_Order_OrderIdFkNavigationOrderId",
                table: "Order_Status");


            migrationBuilder.DropIndex(
                name: "IX_Order_Status_OrderIdFkNavigationOrderId",
                table: "Order_Status");

            migrationBuilder.DropColumn(
                name: "OrderIdFkNavigationOrderId",
                table: "Order_Status");

            migrationBuilder.AddColumn<int>(
                name: "orderStatus1",
                table: "Order",
                nullable: true);

           /* migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "713f0e57-318a-4476-b1a9-106277bb0a4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f350ae72-afdb-4bda-a06f-c8ef05530137");

            

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f0728dde-0ad4-4120-b16a-eb965e7d128b", "376f35d4-b780-4c6b-ba22-b50befc0e290", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e098760e-864e-4430-a05e-930015672101", "1bdb0c32-1bd3-47ce-b717-1bdebcb830dc", "Administrator", "ADMINISTRATOR" });
            */
            migrationBuilder.CreateIndex(
                name: "IX_Order_Status_Order_Id_FK",
                table: "Order_Status",
                column: "Order_Id_FK");

            migrationBuilder.AddForeignKey(
                name: "Order_Status_Order_FK",
                table: "Order_Status",
                column: "Order_Id_FK",
                principalTable: "Order",
                principalColumn: "Order_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "Order_Status_Order_FK",
                table: "Order_Status");

            migrationBuilder.DropIndex(
                name: "IX_Order_Status_Order_Id_FK",
                table: "Order_Status");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e098760e-864e-4430-a05e-930015672101");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0728dde-0ad4-4120-b16a-eb965e7d128b");

            migrationBuilder.DropColumn(
                name: "orderStatus1",
                table: "Order");

            migrationBuilder.AddColumn<int>(
                name: "OrderIdFkNavigationOrderId",
                table: "Order_Status",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f350ae72-afdb-4bda-a06f-c8ef05530137", "4c79e162-a3ef-401c-bdca-91e5965ae101", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "713f0e57-318a-4476-b1a9-106277bb0a4b", "c4660d36-2411-40bc-94e6-320256052a3f", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Order_Status_OrderIdFkNavigationOrderId",
                table: "Order_Status",
                column: "OrderIdFkNavigationOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Status_Order_OrderIdFkNavigationOrderId",
                table: "Order_Status",
                column: "OrderIdFkNavigationOrderId",
                principalTable: "Order",
                principalColumn: "Order_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
