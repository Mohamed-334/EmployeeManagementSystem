using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGlobalFilter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2190cd79-b45c-470e-a7d7-b074b7c4f665", "2876be31-7fdf-4aa9-a27d-c2b4d957b0ba" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0f272376-e28a-4c1d-9c08-34385001a812", "f4969e4b-4e84-484d-b588-83c5bfef4c3a" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5cd0d235-3bb7-4d42-9e71-7519a56dcafe", "11079ac8-a5e2-4c5a-bd48-f84b52b86127" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b0eac71b-35be-44c0-81d2-e0f2869b1a10", "01ad004d-9a59-4ee3-b0d1-084fc2e89b83" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "92143938-9782-4950-b197-0422b8b1c985", "cc1b6e4c-2fbf-4ad9-8f55-24ade546e789" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d2d03fcf-0a39-49bb-a9d1-e1af0d8f98cf", "d6a37adf-4119-4ee6-8c5b-8057b3efca9f" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b528cf4-138a-4b78-8673-410ffa8f3502", "bf88f053-f4ac-4afc-83e0-d17477614868" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1421964-de17-4b3a-abe8-2f709cb288a9", "66d4219a-8d83-4e7e-bbb0-92eed768d53d" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f326d5b9-8490-4ff7-b829-3c9588aebb7b", "be0243e0-22f4-4121-bea9-509e8d078f30" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9047107e-3e0c-4bd1-8a15-badc65b4d294", "c6d42e0a-7031-40ae-836e-6d08c41c3cf1" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "732a9f82-c505-4b08-b203-5e5c7fc56285", "91a2c143-c87e-4653-a9b1-bd0a9f6ddbbb" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f001fa07-04f3-424d-846e-df40b83c5dfd", "dc8a4881-ec08-4cde-93af-1575bf76c0ed" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f41080a-fd5b-4cbd-95b8-6b9bc356b887", "596cb460-fe1a-45f2-82f4-2ce37fbfcf05" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c364e178-04f4-47ae-9db5-faa3b1a51b15", "1c89d1a4-de6a-4cf0-890c-de21f9e93089" });
        }
    }
}
