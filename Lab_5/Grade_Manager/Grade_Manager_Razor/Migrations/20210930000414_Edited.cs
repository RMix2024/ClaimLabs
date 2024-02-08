using Microsoft.EntityFrameworkCore.Migrations;

namespace Grade_Manager_Razor.Migrations
{
    public partial class Edited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassRooms_Students_StudentId",
                table: "ClassRooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Assignments_AssignmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_AssignmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_ClassRooms_StudentId",
                table: "ClassRooms");

            migrationBuilder.DropColumn(
                name: "AssignmentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "ClassRooms");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClassRoomId",
                table: "Students",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ClassRooms",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Assignments",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Grade",
                table: "Assignments",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Assignments",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "ClassRooms",
                columns: new[] { "ClassRoomId", "Name" },
                values: new object[,]
                {
                    { 1, "C#" },
                    { 2, "Java" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "ClassRoomId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "JimBob" },
                    { 2, 1, "Bradley" },
                    { 3, 1, "Steven" }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "AssignmentId", "Grade", "IsComplete", "Name", "StudentId" },
                values: new object[,]
                {
                    { 1, 0.0, false, "Lab_1", 1 },
                    { 2, 0.0, false, "Lab_2", 1 },
                    { 3, 0.0, false, "Lab_3", 1 },
                    { 4, 0.0, false, "Lab_4", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassRoomId",
                table: "Students",
                column: "ClassRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_StudentId",
                table: "Assignments",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Students_StudentId",
                table: "Assignments",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_ClassRooms_ClassRoomId",
                table: "Students",
                column: "ClassRoomId",
                principalTable: "ClassRooms",
                principalColumn: "ClassRoomId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Students_StudentId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_ClassRooms_ClassRoomId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_ClassRoomId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_StudentId",
                table: "Assignments");

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "AssignmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "ClassRoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ClassRooms",
                keyColumn: "ClassRoomId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "ClassRoomId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Assignments");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "AssignmentId",
                table: "Students",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ClassRooms",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "ClassRooms",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Assignments",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateIndex(
                name: "IX_Students_AssignmentId",
                table: "Students",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRooms_StudentId",
                table: "ClassRooms",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRooms_Students_StudentId",
                table: "ClassRooms",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Assignments_AssignmentId",
                table: "Students",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "AssignmentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
