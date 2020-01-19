using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace inv.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "day_retrieved",
                table: "product");

            migrationBuilder.AddColumn<string>(
                name: "Hardware",
                table: "product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hardware",
                table: "product");

            migrationBuilder.AddColumn<DateTime>(
                name: "day_retrieved",
                table: "product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
