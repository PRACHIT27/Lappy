using Microsoft.EntityFrameworkCore.Migrations;
using System.Net.NetworkInformation;


namespace Lappy.Data.Migrations
{
    public partial class RemoveModelID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
        name: "LaptopModelId",
        table: "OrderDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}