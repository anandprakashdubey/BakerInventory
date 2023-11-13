using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakerInventory.Migrations
{
    public partial class initialmigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Bakery",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Bakery");
        }
    }
}
