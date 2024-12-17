using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class AddEndTimeColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Attendance",
                newName: "StartTime");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "EndTime",
                table: "Attendance",
                type: "Time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6021d777-b536-429a-a566-b3af82b08d45", "c03bb24c-826b-48ba-874d-8e25bc172836" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "65ce119c-8ac7-4774-9342-7fd9d7f416ed", "548929cf-bbf3-45d2-a3f6-d615df1f496c" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "112df1e4-db1e-4d22-beb5-908117269303", "e1982d03-d1e7-46bb-b09b-4dd451bf24d7" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2de68aaf-5ebb-4ad4-9cd1-e5e01eca2bc9", "f59a47be-e13a-41c2-b4f3-2c016335ed81" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "14541700-f165-4dd6-82f8-f9971835649c", "c6ca45fa-893a-4713-8668-1ca30c90a11a" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "99408f6a-3e63-4906-9b71-337e2a66d74f", "2f12b9eb-7ed5-4e11-862a-97a58cd82b6b" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "697d0718-cb6c-4120-83b2-58a0cbda0555", "1bec8bfe-8d47-40fb-96f2-f290c91e5b8f" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "71181d8b-8ea7-41a7-9b87-c2bb4d51660c");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "6126fc38-e76c-4371-9001-7e69077581bf");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Attendance");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Attendance",
                newName: "Time");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29335551-c897-4d9c-96ee-3cfd3bb5e658", "651e7535-d536-4a1f-8759-79a49480656e" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be60e69d-432f-4963-983b-75e48cb64243", "c4c943b3-9d6c-4424-b01f-d74cf816eda6" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b598973a-5c38-4ba1-8625-c8d4444ae6a9", "6393e922-cd94-4cac-9a32-ce19c1b55ebf" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "19565749-0b0a-4ffa-afef-6ce3dfa2069c", "4f2d4093-7288-4976-a4e9-104807c47b73" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2abbf13-752b-430c-98aa-ac01a7bef08a", "cb55095a-865d-41ce-a4a2-867c81002fda" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5bbc7501-01c4-4eac-a7c4-0fc1cd1d653e", "13038552-1ba0-4747-9dbb-06aafc2c14b4" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c4f9a4b1-f848-4681-9d93-30a51b09620b", "489d36b9-eba1-4bf2-a01a-d01183351dad" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "a2108885-2a45-4898-99a1-7ec3540aa94d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "3740b702-1f80-4e43-9f14-214a6e5432d1");
        }
    }
}
