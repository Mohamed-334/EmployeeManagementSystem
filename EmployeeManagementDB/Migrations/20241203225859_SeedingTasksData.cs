using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class SeedingTasksData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3c074373-b42e-4fec-87eb-4265d7e0f2af");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "c303db83-6450-4490-888b-1770931c4184");

            migrationBuilder.DropColumn(
                name: "At",
                table: "Attendance");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeadLine",
                table: "Tasks",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SendAt",
                table: "Reports",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Attendance",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2d12e237-d55e-4c07-891b-880e0bcec1d9");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2f34cdf4-2ff3-44b4-9f70-294b9cf7a05c");

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Attendance");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeadLine",
                table: "Tasks",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SendAt",
                table: "Reports",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "At",
                table: "Attendance",
                type: "DateTime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhoto", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3c074373-b42e-4fec-87eb-4265d7e0f2af", 0, "Alex", "b21017ff-3f8a-42e5-89d8-a68f65653a07", null, "Youssef1234.com", false, false, null, null, null, "EntaMalOmkTany.1516", "01049834561", false, null, "58dfb1c8-362c-4aed-bd49-9174e9447269", false, "Youssef Ibrahim" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhoto", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c303db83-6450-4490-888b-1770931c4184", 0, "Kafr AlShikh", "b8ecf817-115b-4ef5-bfc3-53a6995f1b70", null, "mohamedaboelez334@gmail.com", false, false, null, null, null, "EntaMalOmk.1516", "01068706845", false, null, "56e5581c-8ddb-4da9-94be-987e3829923f", false, "Mohamed Ibrahim" });
        }
    }
}
