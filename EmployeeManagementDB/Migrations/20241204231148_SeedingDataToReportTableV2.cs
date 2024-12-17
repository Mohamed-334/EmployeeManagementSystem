using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class SeedingDataToReportTableV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9cef0f82-0d26-40f2-b0f6-fd58fe03ca0b", "afa99f2e-7b7c-4b7d-8bd4-7643932a202a" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f2e47a8-2c2d-4d24-a405-e34e54084cb5", "cf84469e-0a09-47fa-91be-def76c33e801" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0718f292-6d9e-47ee-957f-d35fb9fb7bbc", "5436d094-4af7-41bb-8c82-fe7296ca52e2" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac394cfb-9364-4000-9376-5a32a263e006", "012c30c3-2723-4e4b-bb20-8ba86be5fcdd" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2e44fd11-d1ef-4f07-b51d-2a4b4ba81f4e", "31ef48c2-cb8d-4af3-8c63-8c77c441d3b7" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "171182a4-ac5a-4af8-9867-3394db0d917c", "1d164aba-2bb0-4801-be3b-2008fa354c9e" });

            migrationBuilder.InsertData(
                table: "Reports",
                columns: new[] { "Id", "EmployeeId", "Body", "Header", "SendAt" },
                values: new object[,]
                {
                    { 1, "3", "Login Page has Been Completed", "Login Page", new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "3", " Back-end Login Page has Been Completed", "Back-end Login Page", new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reports",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e37cf59e-0ffe-4e11-90c6-4b681091ae58", "22cf54dd-8681-4e81-895d-54918cfca9df" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f021e8bb-5915-4e7d-8ded-1be61ab2e28a", "71baf8b7-4628-440d-a702-93a57d59040f" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d35c58e6-86b6-437e-9604-01ca53619c46", "d65a9474-7c5b-45ce-8fc6-9eb196a612ac" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f3bc8c92-f4a8-4806-aa61-a624b8d6b612", "0c50f2b6-1e4b-4d49-bff2-3baba93b857e" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "824b747c-0849-4dcb-ae04-455da00daa5c", "86a95861-8388-4174-bdf0-bab067ccf1f1" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7fdb41f3-8671-4218-a562-302c35f187dd", "43dfc4a6-ffb5-4973-9ec6-776f3b1a45fd" });
        }
    }
}
