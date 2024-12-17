using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class AddVacationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "At",
                table: "Vacations",
                type: "Date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "At",
                table: "Vacations");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c967b3af-709b-4762-a2a4-b62bdad1a3aa", "0afc90f5-ac0e-482c-b12d-9143cba6f70e" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bf9163fc-5537-492b-aa0e-ddb5d937262c", "f9f95b96-1725-498a-9246-c6dbffeb7cd0" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d119d807-3d7d-4918-8889-34d16fc5409f", "b5be6706-2e1d-490e-a714-7aba0aec9b86" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "aec270a6-ecad-4928-86b1-3148006d6581", "bda4c392-916e-4a8e-8da9-61f515f53ee0" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e7ea518b-d781-4a47-bbd4-5aa15b2e96d5", "3383cb3c-3a06-4f2e-b9f3-1d95a040bab6" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c3e598b-8fef-437d-8cdc-5f31876ca3c9", "10c881c1-ca85-4f8a-969d-3c18be01c15f" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8c5a8fd5-a13c-42cf-90be-0a4ceeb4dbb8", "a04d792a-965a-416f-8055-1e8e94d6cbf1" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "87d21609-a112-4757-b37f-c89a01ddbfea");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "36da65a5-d5b3-47b2-982b-fa674919efbc");
        }
    }
}
