using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class UpdateGlobalFilter2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5f4f8394-e54f-46ae-a14f-26a6db1ce744", "79afab2f-81e9-409a-abe3-7bdc4f9461b6" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0b839967-36dc-4b97-9e54-61670455de03", "aefa630c-c629-409b-8171-0f6692227574" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0c98ff2-ff4b-4a54-a87c-09d4b45adaa1", "6eaf547c-4f01-4c1b-b4b0-e5be40b2c9ad" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d039dc9c-8988-49ff-b97a-cfce3562cac3", "c4ac57ed-d6c9-4086-b0d1-8e09635ed76c" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d891e256-e436-4062-a963-01f0704cef32", "2580eb64-0d46-4c1d-9043-2dc65106da0b" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ddea5c0d-27aa-4e22-a5c6-d0bc15bd2eb4", "3a59b3f2-0124-46cd-a57d-a98100e70ce9" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f66a5f1-e79d-46f9-83b7-65d7232334f8", "d08ca34f-85ed-4ffc-8cb3-546e348a5c83" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
