using Microsoft.EntityFrameworkCore.Migrations;

namespace Grade_Manager_Razor.Migrations
{
    public partial class seededmore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "ClassRoomId", "Name" },
                values: new object[,]
                {
                    { 4, 2, "Jonathon" },
                    { 5, 2, "Heather" },
                    { 6, 2, "Warren" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 6);
        }
    }
}
