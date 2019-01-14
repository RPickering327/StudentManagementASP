using Microsoft.EntityFrameworkCore.Migrations;

namespace Ewart.Migrations
{
    public partial class YearlyBudget : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "YearlyBudget",
                table: "userSettings",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearlyBudget",
                table: "userSettings");
        }
    }
}
