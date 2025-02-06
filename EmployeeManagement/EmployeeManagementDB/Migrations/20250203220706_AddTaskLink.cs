using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TaskLink",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f3646824-cc45-4cc1-a90b-745eb19361a2", "b3868c74-b43e-498e-ad5c-6ad0cec08237" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "071b8267-3025-45ef-934b-668d67da40dc", "59098fac-6911-40fb-9439-19f8d9cbfd5e" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fff3b601-ca61-4285-9538-5c94f0329676", "a147cdf5-ed33-440f-8655-d20a5983a385" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "02e45683-24b6-4702-8de1-54abf94e0e81", "ad7c924e-63df-48f4-a64f-030769a72906" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9cdb6c2f-3936-467c-bd3c-470fbca906a8", "602874ee-0578-4192-97fa-07e34f2c60ce" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "31162202-17f9-46aa-9626-393353be2848", "5fea8af1-4342-43a7-86e3-c5ac9d8ea72e" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "14b101b4-da29-4682-9971-5a56e9fc0d96", "91acdfb5-b579-4aab-b8b8-a7e4a1f847cb" });

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 6,
                column: "TaskLink",
                value: null);

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 7,
                column: "TaskLink",
                value: null);

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 8,
                column: "TaskLink",
                value: null);

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 9,
                column: "TaskLink",
                value: null);

            migrationBuilder.UpdateData(
                table: "Job",
                keyColumn: "Id",
                keyValue: 10,
                column: "TaskLink",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TaskLink",
                table: "Job");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2a2dd274-a659-4fc7-849f-96578eb53310", "032c21e5-be2f-4e48-9330-c74a0d12bbfa" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1004fa49-a72c-4182-bef9-ff49204efce5", "8c36a663-fd1c-4092-9130-5d684486cade" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5db56660-21fb-435a-8755-78b952680ada", "0f00a510-4fb4-4347-b8cf-8a416be31286" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3e6893a9-578e-48fb-b7a6-e8b996d068b5", "f73521fa-3403-4f4d-ba27-d4cf05130188" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "daaaec6a-ff42-4521-b591-d8122fe026b2", "5f9e9cad-2bf1-46a7-a469-b93f60ad9d88" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "69a47b83-b21f-42b0-9a34-db814ae74d9c", "17fec1a0-5a22-4920-b234-424a09cf3184" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ff2844e7-bf0f-4421-9450-f51fdf6e0b13", "26abe6db-d812-46e9-922d-1667076e1189" });
        }
    }
}
