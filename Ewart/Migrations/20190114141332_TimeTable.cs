using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ewart.Migrations
{
    public partial class TimeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "04d6c98e-bb55-4a49-a5dc-16c3c97aeaa3", "1339318a-7b74-4139-9fae-ea9a432ca741" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "7e906798-faca-4cfc-b29d-f46e7c5f3112", "7da63574-a8ce-4182-b1bf-2bdceb27bff9" });

            migrationBuilder.DropColumn(
                name: "LessonDuration",
                table: "classes");

            migrationBuilder.CreateTable(
                name: "timetables",
                columns: table => new
                {
                    TimeTableId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateOfLesson = table.Column<DateTime>(nullable: false),
                    Duration = table.Column<TimeSpan>(nullable: false),
                    SubjectDetailsSubjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_timetables", x => x.TimeTableId);
                    table.ForeignKey(
                        name: "FK_timetables_classes_SubjectDetailsSubjectId",
                        column: x => x.SubjectDetailsSubjectId,
                        principalTable: "classes",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66a30f29-9866-4c89-88e1-f06316ccfd82", "df911188-de6a-4407-ac7e-3945ab6a71a5", "Baseuser", "BASEUSER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "619030cf-305b-4ad7-955f-4c90da304f97", "51605ee8-21ea-418a-9a73-8d3a220db6a9", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_timetables_SubjectDetailsSubjectId",
                table: "timetables",
                column: "SubjectDetailsSubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "timetables");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "619030cf-305b-4ad7-955f-4c90da304f97", "51605ee8-21ea-418a-9a73-8d3a220db6a9" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "66a30f29-9866-4c89-88e1-f06316ccfd82", "df911188-de6a-4407-ac7e-3945ab6a71a5" });

            migrationBuilder.AddColumn<double>(
                name: "LessonDuration",
                table: "classes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04d6c98e-bb55-4a49-a5dc-16c3c97aeaa3", "1339318a-7b74-4139-9fae-ea9a432ca741", "Baseuser", "BASEUSER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7e906798-faca-4cfc-b29d-f46e7c5f3112", "7da63574-a8ce-4182-b1bf-2bdceb27bff9", "Admin", "ADMIN" });
        }
    }
}
