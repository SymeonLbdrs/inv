using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace inv.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    day_received = table.Column<DateTime>(nullable: false),
                    day_retrieved = table.Column<DateTime>(nullable: false),
                    serial_number = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    contract = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product");
        }
    }
}
