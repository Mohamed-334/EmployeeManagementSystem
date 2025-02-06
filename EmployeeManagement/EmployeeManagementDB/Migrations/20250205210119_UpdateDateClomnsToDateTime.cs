using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDateClomnsToDateTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "At",
                table: "Vacation",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SendAt",
                table: "Report",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeadLine",
                table: "Job",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6fa1cae9-685f-4079-9e79-cc791b03c2c6", "c71a1c2c-b148-4d56-a8d8-41a02f65d3a0" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "06d9b675-038c-4e9d-973b-e2b316fb940a", "a040a58e-169c-4aec-8f9b-f75b0fac7a5a" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d20632b-3208-44ce-a115-a294165209ba", "b61b8ca1-bd7e-44ba-bbcc-00d2e66f3fd3" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a46238c1-6fcb-4631-b91d-d5a9117d1805", "4c501d24-fdb3-4d5e-8abe-41fc6bef8288" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0b02c2a9-0ffa-4da0-8a89-b0f76d3a2ab1", "aa2e0449-c5c6-47bc-afc9-14eb0271c8a4" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6b8ff57b-979e-40a7-a38e-a8078b7d36df", "b154fe07-052a-49a6-8085-618a1bd1b3df" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "95ec125e-738c-4e79-b7cb-82a54d837256", "4f5bdce6-defd-45b8-b837-7a1a5556cb49" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "At",
                table: "Vacation",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SendAt",
                table: "Report",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeadLine",
                table: "Job",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

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
    }
}
