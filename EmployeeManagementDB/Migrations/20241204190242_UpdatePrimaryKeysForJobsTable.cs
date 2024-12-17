using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class UpdatePrimaryKeysForJobsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "905d68c2-8719-422d-b19f-ab2795b606a0", "64d64063-08c9-4aa4-a542-5be4e3e65314" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2749631c-48bb-4e7d-bb2b-a6a797682bb1", "52a8b751-6213-4706-a4c7-bf0c1d373559" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff9d08bb-1094-49c9-8d63-225fcd4ec8c6", "6e16a687-6962-475b-a6bd-7e11a2b53123" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "934d587a-790a-4cdf-bb25-a75b6ce973b0", "988309fe-7187-42fa-96f3-f2457f841b58" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2d417456-7550-4a81-8a40-a83ef702fe97", "045e9f7a-ccbd-42cd-92d1-b03aa940f395" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "86c700b2-82f1-400c-af65-0d60185ae198", "db874f3d-54e9-4d65-a0f0-4ab78cc55a2a" });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "DeadLine", "Done", "EmployeeId", "TaskDescription", "TaskName" },
                values: new object[,]
                {
                    { 6, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "4", "Create Login Page For the Employee System", "LoginPage" },
                    { 7, new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "5", "Create Page that Hold Related Cars Photos", "Photo Package Page" },
                    { 8, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "4", "Create Register Page For the Employee System", "Register Page" },
                    { 9, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2", "Create back-end Login Page For the Employee System", " Back-end Login Page" },
                    { 10, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "1", "Create Back-end Register Page For the Employee System", "Back-end Register Page" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2a02105d-8e20-400f-8552-f23c1c21ecc0", "aba28784-70d2-45d2-b788-5aeb8c037d48" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0192206-4014-42ec-9ae5-736f259dd8d3", "799ccd6c-586f-4fc6-8b18-b90dcc3dee3a" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c318b35c-e658-41a8-bd80-4268a39d484a", "86c65bfe-528e-4fd0-a24a-e12b5677da17" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "45dd157a-4e13-47b6-8ad4-5b1177096ee9", "ac3a4617-cd22-467d-9309-181304d82f42" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76bc9506-f8da-45f0-943f-938736a15ad3", "11893bdf-1d88-4fbc-af4b-373ef2e23860" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a32f9da9-d3d6-4de4-9b8e-d622faf87348", "91f762a7-94eb-4cd2-8892-39f54f2516eb" });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "DeadLine", "Done", "EmployeeId", "TaskDescription", "TaskName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "4", "Create Login Page For the Employee System", "LoginPage" },
                    { 2, new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "5", "Create Page that Hold Related Cars Photos", "Photo Package Page" },
                    { 3, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "4", "Create Register Page For the Employee System", "Register Page" },
                    { 4, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2", "Create back-end Login Page For the Employee System", " Back-end Login Page" },
                    { 5, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "1", "Create Back-end Register Page For the Employee System", "Back-end Register Page" }
                });
        }
    }
}
