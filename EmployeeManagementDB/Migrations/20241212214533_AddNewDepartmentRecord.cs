using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class AddNewDepartmentRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentName", "EmployeeId", "Position" },
                values: new object[] { 6, "Adminstration", "7", "Admin" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3c46c5af-53aa-472d-9df0-97134f7dcf4f", "4a179484-0964-43f6-87c6-e4b52bc71d6a" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2461792-9b48-4781-9c51-1f305ae23b67", "fa0901bf-5435-49fc-bb7f-d302e4b1fa28" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9bb7ca73-fa9f-4e57-98b7-0626e651da2e", "f340d3a3-8809-4d51-872f-1515c24541ce" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "644cf6bd-a483-4fb2-b5dc-307bfbc804e7", "7e2baa53-f80f-4639-8d28-b818d6dacdbe" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3cc69ad9-8de1-4ce5-941a-983fdb653add", "7bf600c5-3b66-4468-ab9a-a46b61b7fb03" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de682d9c-0b29-4b14-8068-115813cc52d4", "5d44c07d-786f-4cf7-9f6f-7fe29cbd485c" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a032157-556d-4369-853a-638b99eb4db4", "7246a777-a84e-45d1-9743-7377202f4009" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b96ea46f-f7c0-4838-b984-229483a88ce4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "701a0434-e71e-4c09-b224-460a9e6c5fe9");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89514ca9-b011-4649-a40d-4ccee62f398b", "e061934a-4a7c-42ff-b4c9-4a14233aac26" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "901a7574-2fc4-42c5-90df-a1cdc0cc988f", "50b3a87b-0832-44ea-88f7-9654cb3735e0" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7f0a7477-b0b2-41cb-af6a-d0bdef39ba35", "c48274c5-b59e-4bb4-af01-cb465aa8e7d3" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42bfd88b-d826-4863-93c5-6217cfa0af19", "6b6d1b43-2403-4578-b00e-de90a140eb54" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "089706e5-a4d0-4437-8d8a-d00eccb925fb", "aac26ba4-8dd1-441e-bd95-058c0d2c978b" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "53408197-a995-446f-bbde-8657b80364eb", "f34cfc14-daf7-4698-a8a1-1ced55bf7201" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b614ff6e-8b75-4f22-9429-5cae171ca090", "63904fda-75d2-4ce5-aeb6-11736bcfb4f5" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "eb165421-571f-4029-9884-d976c709f35a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7807cea5-42ff-4d38-821b-9e9ea947aabc");
        }
    }
}
