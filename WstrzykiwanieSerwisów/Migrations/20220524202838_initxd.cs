using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WstrzykiwanieSerwisów.Migrations
{
    public partial class initxd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLeapYear",
                table: "Person");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLeapYear",
                table: "Person",
                type: "bit",
                maxLength: 100,
                nullable: false,
                defaultValue: false);
        }
    }
}
