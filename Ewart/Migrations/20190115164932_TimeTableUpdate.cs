using Microsoft.EntityFrameworkCore.Migrations;

namespace Ewart.Migrations
{
    public partial class TimeTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "619030cf-305b-4ad7-955f-4c90da304f97", "51605ee8-21ea-418a-9a73-8d3a220db6a9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "66a30f29-9866-4c89-88e1-f06316ccfd82", "df911188-de6a-4407-ac7e-3945ab6a71a5" });

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "timetables",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8c877a6f-0a08-4074-8406-75a7db287008", "520358bb-1ccb-4804-9615-c83ba789a4d6", "Baseuser", "BASEUSER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "21ce9e45-5696-487d-9b4c-1716944f0862", "f74bfc14-9b5a-4fb5-999f-f9283a1e877b", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "21ce9e45-5696-487d-9b4c-1716944f0862", "f74bfc14-9b5a-4fb5-999f-f9283a1e877b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "8c877a6f-0a08-4074-8406-75a7db287008", "520358bb-1ccb-4804-9615-c83ba789a4d6" });

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "timetables");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66a30f29-9866-4c89-88e1-f06316ccfd82", "df911188-de6a-4407-ac7e-3945ab6a71a5", "Baseuser", "BASEUSER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "619030cf-305b-4ad7-955f-4c90da304f97", "51605ee8-21ea-418a-9a73-8d3a220db6a9", "Admin", "ADMIN" });
        }
    }
}
