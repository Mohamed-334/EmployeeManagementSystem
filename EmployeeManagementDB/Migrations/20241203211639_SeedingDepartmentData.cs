using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class SeedingDepartmentData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "0caa34ae-8652-4c24-9278-75abae3f3d5a");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "f5edfca5-e878-4f77-a72f-8ebf594bd037");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhoto", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3c074373-b42e-4fec-87eb-4265d7e0f2af", 0, "Alex", "b21017ff-3f8a-42e5-89d8-a68f65653a07", null, "Youssef1234.com", false, false, null, null, null, "EntaMalOmkTany.1516", "01049834561", false, null, "58dfb1c8-362c-4aed-bd49-9174e9447269", false, "Youssef Ibrahim" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhoto", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c303db83-6450-4490-888b-1770931c4184", 0, "Kafr AlShikh", "b8ecf817-115b-4ef5-bfc3-53a6995f1b70", null, "mohamedaboelez334@gmail.com", false, false, null, null, null, "EntaMalOmk.1516", "01068706845", false, null, "56e5581c-8ddb-4da9-94be-987e3829923f", false, "Mohamed Ibrahim" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3c074373-b42e-4fec-87eb-4265d7e0f2af");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "c303db83-6450-4490-888b-1770931c4184");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhoto", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0caa34ae-8652-4c24-9278-75abae3f3d5a", 0, "Alex", "0b7fec7c-4daf-4131-98f0-35ca9ecb1cda", null, "Youssef1234.com", false, false, null, null, null, "EntaMalOmkTany.1516", "01049834561", false, null, "701a40cb-de59-4543-9968-f749ac39ebee", false, "Youssef Ibrahim" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "DepartmentId", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePhoto", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f5edfca5-e878-4f77-a72f-8ebf594bd037", 0, "Kafr AlShikh", "b47cf138-8136-4b72-8dd7-d53f447f0092", null, "mohamedaboelez334@gmail.com", false, false, null, null, null, "EntaMalOmk.1516", "01068706845", false, null, "33297f36-7c2f-4ae4-9058-71d528f6a635", false, "Mohamed Ibrahim" });
        }
    }
}
