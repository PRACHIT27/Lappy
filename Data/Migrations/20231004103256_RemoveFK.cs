using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lappy.Data.Migrations
{
    public partial class RemoveFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Laptops_LaptopId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_LaptopId",
                table: "OrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "LaptopModelId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_LaptopModelId",
                table: "OrderDetails",
                column: "LaptopModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Laptops_LaptopModelId",
                table: "OrderDetails",
                column: "LaptopModelId",
                principalTable: "Laptops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Laptops_LaptopModelId",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_LaptopModelId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "LaptopModelId",
                table: "OrderDetails");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_LaptopId",
                table: "OrderDetails",
                column: "LaptopId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Laptops_LaptopId",
                table: "OrderDetails",
                column: "LaptopId",
                principalTable: "Laptops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
