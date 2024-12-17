using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class AddTimeForAttendance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Time",
                table: "Attendance",
                type: "Time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "Attendance");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e62130ac-b90f-4997-a42a-c0e258823a88", "977f1aa0-2503-4e91-913b-4135049324cb" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d2865eb-5f8e-4855-ba89-89cb2a6c0fb1", "9b9deaaf-79a7-4d14-99b6-5f72a6b75204" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e50de4e0-c3fa-4c54-a602-b54a717c2eec", "0378dd9b-bcf1-4935-901e-5e905faadfc6" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5b4af22a-b5da-4229-b0ee-66c60b54d888", "b9721a32-181f-4ee3-818e-31a469c6bb9b" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f35b0afa-50d0-43c8-94ff-10634f66405d", "d2f4dae0-c696-4926-ad9c-e4190616dabc" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "48a711c2-6e8c-4162-b401-a82b51455f00", "cc7b5897-fc97-4a3e-bdbe-8789eb787f3d" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3100b442-4972-45b4-a926-58fba9692cf0", "38174f92-8b9f-425e-a2b5-1c6514deef27" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "682882de-b2e1-45a6-b344-e04de6901b6b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1376ff85-b0bc-44b7-969d-0a9efb9ba239");
        }
    }
}
