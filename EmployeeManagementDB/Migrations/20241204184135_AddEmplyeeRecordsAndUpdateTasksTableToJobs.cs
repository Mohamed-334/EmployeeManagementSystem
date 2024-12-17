using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class AddEmplyeeRecordsAndUpdateTasksTableToJobs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2d12e237-d55e-4c07-891b-880e0bcec1d9");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2f34cdf4-2ff3-44b4-9f70-294b9cf7a05c");

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TaskName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    TaskDescription = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    Done = table.Column<bool>(type: "bit", nullable: false),
                    DeadLine = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhoto", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0621d553-4789-4590-abdb-0b598b7b1122", 0, "Alex", "4560b8ac-1292-443e-a2a9-5d3a5680a0f2", null, "AnasMohamed784.com", false, false, null, null, null, "EntaMalOmk4.1516", "01249834561", false, null, "eb6a7f4b-603c-401b-91a2-b6352094cb3d", false, "Anas Mohamed" },
                    { "361125fb-80f8-47c5-bbce-4c494b2ac9ca", 0, "Alex", "2d9eb852-279b-4582-8341-339b210ca349", null, "Youssef1234.com", false, false, null, null, null, "EntaMalOmkTany.1516", "01049834561", false, null, "cb943d8f-5057-4fe6-a9d0-56a59b396aa9", false, "Youssef Ibrahim" },
                    { "75fe677f-3dc7-42f2-8e64-c4388b941de6", 0, "Kafr AlShikh", "ce911478-3bd8-45be-a64e-96c4c10ae844", null, "KhaledAhmed@gmail.com", false, false, null, null, null, "EntaMalOmk5.1516", "01532943571", false, null, "029f4744-262a-4343-83cf-583515abf942", false, "Khaled Ahmed    " },
                    { "867ddd36-2437-41d0-8f6a-073c2cdf9328", 0, "Alex", "ca395d81-6383-4425-ac5a-e768aa22673d", null, "Alaa841.com", false, false, null, null, null, "EntaMalOmkTany.1516", "0107835641", false, null, "cba62b83-a20f-470b-9eb6-4012ee58bca7", false, "Alaa Osama" },
                    { "b7289caf-e8a0-41fb-9e6a-d7d3008f03e7", 0, "Alex", "390dc8a5-367c-4624-b1ab-a9e1d16e1f4b", null, "Khaled333@gmail.com", false, false, null, null, null, "EntaMalOmkTalet.1516", "0118735194", false, null, "3aac502a-9f29-4ebc-816e-042db3cef657", false, "Khaled Alaa" },
                    { "d704b3ee-eea3-400f-8098-5550622262b6", 0, "Kafr AlShikh", "650707b3-8f20-461b-9259-bd52b9c4af7d", null, "mohamedaboelez334@gmail.com", false, false, null, null, null, "EntaMalOmk.1516", "01068706845", false, null, "d738790f-597f-413f-9981-f0ab4250ce84", false, "Mohamed Ibrahim" }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "DeadLine", "Done", "EmployeeId", "TaskDescription", "TaskName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Create Login Page For the Employee System", "LoginPage" },
                    { 2, new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Create Page that Hold Related Cars Photos", "Photo Package Page" },
                    { 3, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Create Register Page For the Employee System", "Register Page" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_EmployeeId",
                table: "Jobs",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "0621d553-4789-4590-abdb-0b598b7b1122");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "361125fb-80f8-47c5-bbce-4c494b2ac9ca");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "75fe677f-3dc7-42f2-8e64-c4388b941de6");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "867ddd36-2437-41d0-8f6a-073c2cdf9328");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "b7289caf-e8a0-41fb-9e6a-d7d3008f03e7");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "d704b3ee-eea3-400f-8098-5550622262b6");

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeadLine = table.Column<DateTime>(type: "Date", nullable: false),
                    Done = table.Column<bool>(type: "bit", nullable: false),
                    TaskDescription = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    TaskName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhoto", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2d12e237-d55e-4c07-891b-880e0bcec1d9", 0, "Alex", "e7df0237-009b-4b66-ac8a-25d1c142b94f", null, "Youssef1234.com", false, false, null, null, null, "EntaMalOmkTany.1516", "01049834561", false, null, "7c42cf2a-73a5-41d4-bcb0-786a96b8fcbf", false, "Youssef Ibrahim" },
                    { "2f34cdf4-2ff3-44b4-9f70-294b9cf7a05c", 0, "Kafr AlShikh", "09c00f66-7d49-4895-852a-94c7fcf3e4ca", null, "mohamedaboelez334@gmail.com", false, false, null, null, null, "EntaMalOmk.1516", "01068706845", false, null, "bf798b55-e379-413d-92d2-dd0245de04ca", false, "Mohamed Ibrahim" }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "DeadLine", "Done", "EmployeeId", "TaskDescription", "TaskName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Create Login Page For the Employee System", "LoginPage" },
                    { 2, new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Create Page that Hold Related Cars Photos", "Photo Package Page" },
                    { 3, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, "Create Register Page For the Employee System", "Register Page" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_EmployeeId",
                table: "Tasks",
                column: "EmployeeId");
        }
    }
}
