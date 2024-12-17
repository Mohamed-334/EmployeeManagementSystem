using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class UpdateForeignKeysForEmplyeesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "fda92436-05b2-44a3-9040-45125ea444a7", 2, "4079eda2-6d95-4543-b80b-2d7fc6e9e6a1" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "d32e0c62-b6d7-4a7f-8622-69dbd6518d67", 3, "45d698cd-7375-4f1a-9471-a16af95dfdff" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "4cb317ba-123a-42fa-89a5-c5ea8ac65d30", 4, "7ace33fb-7fc2-4de3-a565-32ec97333405" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "680ee951-da71-410c-b556-bb1784a5ee99", 5, "38a331a9-d422-4e96-88bd-b15c3c13d04a" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "fef1bd90-8c3c-4e5f-b320-358685f7d781", 2, "f7f9d12b-ef9c-42fe-86b9-9f23533af8d4" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "e6b7128a-1323-4353-af1a-0b13814c19b0", 4, "6489a2cc-1fbb-4c1d-b5bc-ddab5adffcdc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "905d68c2-8719-422d-b19f-ab2795b606a0", null, "64d64063-08c9-4aa4-a542-5be4e3e65314" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "2749631c-48bb-4e7d-bb2b-a6a797682bb1", null, "52a8b751-6213-4706-a4c7-bf0c1d373559" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "ff9d08bb-1094-49c9-8d63-225fcd4ec8c6", null, "6e16a687-6962-475b-a6bd-7e11a2b53123" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "934d587a-790a-4cdf-bb25-a75b6ce973b0", null, "988309fe-7187-42fa-96f3-f2457f841b58" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "2d417456-7550-4a81-8a40-a83ef702fe97", null, "045e9f7a-ccbd-42cd-92d1-b03aa940f395" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "DepartmentId", "SecurityStamp" },
                values: new object[] { "86c700b2-82f1-400c-af65-0d60185ae198", null, "db874f3d-54e9-4d65-a0f0-4ab78cc55a2a" });
        }
    }
}
