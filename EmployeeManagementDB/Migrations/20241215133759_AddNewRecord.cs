using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class AddNewRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "positions",
                keyColumn: "Id",
                keyValue: 3,
                column: "PositionName",
                value: "Laravel Developer");

            migrationBuilder.UpdateData(
                table: "positions",
                keyColumn: "Id",
                keyValue: 4,
                column: "PositionName",
                value: "React Developer");

            migrationBuilder.UpdateData(
                table: "positions",
                keyColumn: "Id",
                keyValue: 5,
                column: "PositionName",
                value: "Angular Developer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d210bad-3d5f-4845-ade9-dc80f65d611b", "8a314e11-3978-4c41-8b45-cd61657dff4e" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d384c3e7-75f6-4d4d-b4ac-f54a33aecc54", "2c340439-6dd6-48b5-95ea-db1d6b407c41" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "848e7c88-ea8d-42a2-afe2-b9e13dd89ff4", "a699f3bc-9ffc-41e3-b640-95d30aeb7c28" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f5ccabb7-d840-4ebc-a11e-399c52b16ee0", "10cc05fd-e370-4e6a-8da3-c5bf6d375cdf" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9d77bad-7e43-453b-bf61-c6186289a949", "a644240f-c7dc-44cf-bf09-b6d6c29eb065" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d9d6cda4-b2aa-498f-a357-df0742c24d35", "b1866c1d-d058-4b98-a04d-ffec13103e5f" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad0eb2b1-ec03-4d46-b8d3-67097072d2a3", "894e7535-1b1e-4526-a9ba-3d26991ddd0d" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7a2e56ef-39d0-4e3c-8906-e28b77a0a617");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "201be277-11c9-4fdf-bb04-4abe079adb03");

            migrationBuilder.UpdateData(
                table: "positions",
                keyColumn: "Id",
                keyValue: 3,
                column: "PositionName",
                value: "Laravel");

            migrationBuilder.UpdateData(
                table: "positions",
                keyColumn: "Id",
                keyValue: 4,
                column: "PositionName",
                value: "React");

            migrationBuilder.UpdateData(
                table: "positions",
                keyColumn: "Id",
                keyValue: 5,
                column: "PositionName",
                value: "Angular");
        }
    }
}
