using Microsoft.EntityFrameworkCore.Migrations;

namespace Ewart.Migrations
{
    public partial class seedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04d6c98e-bb55-4a49-a5dc-16c3c97aeaa3", "1339318a-7b74-4139-9fae-ea9a432ca741", "Baseuser", "BASEUSER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e906798-faca-4cfc-b29d-f46e7c5f3112", "7da63574-a8ce-4182-b1bf-2bdceb27bff9", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "04d6c98e-bb55-4a49-a5dc-16c3c97aeaa3", "1339318a-7b74-4139-9fae-ea9a432ca741" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7e906798-faca-4cfc-b29d-f46e7c5f3112", "7da63574-a8ce-4182-b1bf-2bdceb27bff9" });
        }
    }
}
