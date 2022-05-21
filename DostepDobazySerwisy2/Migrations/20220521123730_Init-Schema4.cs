using Microsoft.EntityFrameworkCore.Migrations;

namespace DostepDobazySerwisy2.Migrations
{
    public partial class InitSchema4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Person",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Person");
        }
    }
}
