using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoftLineTestTask.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decree = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FieldText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubTable_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Birthday", "Decree", "Name", "Position", "Text" },
                values: new object[,]
                {
                    { 1, new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), true, "Tom", "1", "1" },
                    { 2, new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), true, "Tom", "1", "1" },
                    { 3, new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), true, "Tom", "1", "1" },
                    { 4, new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), true, "Tom", "1", "1" },
                    { 5, new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), true, "Tom", "1", "1" },
                    { 6, new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), true, "Tom", "1", "1" },
                    { 7, new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), true, "Tom", "1", "1" },
                    { 8, new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), true, "Tom", "1", "1" },
                    { 9, new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), true, "Tom", "1", "1" },
                    { 10, new DateTime(2008, 5, 1, 8, 30, 52, 0, DateTimeKind.Unspecified), true, "Tom", "1", "1" }
                });

            migrationBuilder.InsertData(
                table: "SubTable",
                columns: new[] { "Id", "EmployeeId", "FieldName", "FieldText" },
                values: new object[,]
                {
                    { 1, 5, "Рад работать в компании", "да" },
                    { 2, 6, "Всегда в хорошем настроении", "да" },
                    { 3, 10, "Первое поле", "действительно первое" },
                    { 4, 10, "Второе поле", "действительно второе" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubTable_EmployeeId",
                table: "SubTable",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubTable");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
