﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lappy.Data.Migrations
{
    public partial class RemovedModelID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
        name: "LaptopModelId",
        table: "OrderDetails");
        }
    }
}
