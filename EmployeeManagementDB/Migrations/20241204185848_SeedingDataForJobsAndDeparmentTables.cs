using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class SeedingDataForJobsAndDeparmentTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentName", "EmployeeId", "Position" },
                values: new object[,]
                {
                    { 2, "Back-end", "1", "Dot Net Dev" },
                    { 3, "Back-end", "2", "Laravel" },
                    { 4, "Front-end", "4", "React" },
                    { 5, "Front-end", "5", "Angular" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhoto", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "Kafr AlShikh", "2a02105d-8e20-400f-8552-f23c1c21ecc0", null, "mohamedaboelez334@gmail.com", false, false, null, null, null, "EntaMalOmk.1516", "01068706845", false, null, "aba28784-70d2-45d2-b788-5aeb8c037d48", false, "Mohamed Ibrahim" },
                    { "2", 0, "Alex", "d0192206-4014-42ec-9ae5-736f259dd8d3", null, "Youssef1234.com", false, false, null, null, null, "EntaMalOmkTany.1516", "01049834561", false, null, "799ccd6c-586f-4fc6-8b18-b90dcc3dee3a", false, "Youssef Ibrahim" },
                    { "3", 0, "Alex", "c318b35c-e658-41a8-bd80-4268a39d484a", null, "Khaled333@gmail.com", false, false, null, null, null, "EntaMalOmkTalet.1516", "0118735194", false, null, "86c65bfe-528e-4fd0-a24a-e12b5677da17", false, "Khaled Alaa" },
                    { "4", 0, "Alex", "45dd157a-4e13-47b6-8ad4-5b1177096ee9", null, "AnasMohamed784.com", false, false, null, null, null, "EntaMalOmk4.1516", "01249834561", false, null, "ac3a4617-cd22-467d-9309-181304d82f42", false, "Anas Mohamed" },
                    { "5", 0, "Kafr AlShikh", "76bc9506-f8da-45f0-943f-938736a15ad3", null, "KhaledAhmed@gmail.com", false, false, null, null, null, "EntaMalOmk5.1516", "01532943571", false, null, "11893bdf-1d88-4fbc-af4b-373ef2e23860", false, "Khaled Ahmed    " },
                    { "6", 0, "Alex", "a32f9da9-d3d6-4de4-9b8e-d622faf87348", null, "Alaa841.com", false, false, null, null, null, "EntaMalOmkTany.1516", "0107835641", false, null, "91f762a7-94eb-4cd2-8892-39f54f2516eb", false, "Alaa Osama" }
                });

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmployeeId",
                value: "4");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmployeeId",
                value: "5");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "EmployeeId",
                value: "4");

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "DeadLine", "Done", "EmployeeId", "TaskDescription", "TaskName" },
                values: new object[,]
                {
                    { 4, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "2", "Create back-end Login Page For the Employee System", " Back-end Login Page" },
                    { 5, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "1", "Create Back-end Register Page For the Employee System", "Back-end Register Page" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2");

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

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "EmployeeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "EmployeeId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "EmployeeId",
                value: null);
        }
    }
}
