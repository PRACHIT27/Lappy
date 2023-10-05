using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lappy.Data.Migrations
{
    public partial class AddedObj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Laptops_LaptopModelId",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "LaptopModelId",
                table: "OrderDetails",
                newName: "LaptopModelID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_LaptopModelId",
                table: "OrderDetails",
                newName: "IX_OrderDetails_LaptopModelID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Laptops_LaptopModelID",
                table: "OrderDetails",
                column: "LaptopModelID",
                principalTable: "Laptops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Laptops_LaptopModelID",
                table: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "LaptopModelID",
                table: "OrderDetails",
                newName: "LaptopModelId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderDetails_LaptopModelID",
                table: "OrderDetails",
                newName: "IX_OrderDetails_LaptopModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Laptops_LaptopModelId",
                table: "OrderDetails",
                column: "LaptopModelId",
                principalTable: "Laptops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
