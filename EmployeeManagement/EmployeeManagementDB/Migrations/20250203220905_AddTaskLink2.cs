using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskLink2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaskLink",
                table: "Job",
                type: "varchar(Max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TaskDescription",
                table: "Job",
                type: "varchar(Max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0e605f8-b2ea-459a-b6b2-364c850117d0", "3a96d0e3-d683-4f42-9c0b-431a572a2556" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f65cdad2-d0c5-4682-84b8-47120a110602", "dccdb14f-5ef0-4219-a149-640ca769826f" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "50a1cf50-a9c8-4d06-9faf-db658b4cee44", "30e150cf-23e7-4dfb-926f-5b28d44935d7" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d78f8a50-1f81-4588-8a07-01220b681135", "216e6456-8aa7-42ac-8838-ea3ec6ee5391" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b84975c3-835d-43c4-ac49-ce241a1bdeab", "6ad2f823-a05e-4db6-8ac5-90584fd74f16" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5f231471-9e12-4219-a51a-105090990733", "51f5a25d-8d69-47a6-b3d9-a5a5524ac325" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f40e8a0-7740-4474-8235-095c0adfae1a", "19fe57fc-7322-4b4a-a8fd-d6d5392eda7d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TaskLink",
                table: "Job",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(Max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TaskDescription",
                table: "Job",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(Max)");

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
        }
    }
}
