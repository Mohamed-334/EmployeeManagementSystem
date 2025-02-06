using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAttendance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "TotalTimeWork",
                table: "Attendance",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eee6b599-26ca-404d-a88a-c70191c479b0", "5543c3f1-c209-4bb6-823b-998a123f6e0b" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1ae3cc8f-5e8d-4f06-a838-c8d66af6a831", "7c037ad2-f339-4284-838b-1ee72070b942" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "dd9d3bd2-4783-4fa8-9ce2-77823010a36a", "29b8cb57-9f3a-49f1-a1c5-c599d3df824a" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "18d8c90a-bae2-48f0-b0b2-dea1fe9ea2ba", "ead8e3d0-8583-4795-9d3d-d607607245bd" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "172c71e1-3827-46cc-87fe-fcc867cf4c8a", "b8523ab8-f8c0-4c61-b48e-7cb64e9e7e94" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ebcf67c-4915-40d3-b9ca-5e2ec8e050d0", "a69def4d-71d5-43ee-9488-f9640b7516ae" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5d19e4e8-9fdc-4011-9f07-507d0662eb87", "c3cc666b-c9d5-4420-af3d-14d73608e2c1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "State",
                table: "Attendance");

            migrationBuilder.DropColumn(
                name: "TotalTimeWork",
                table: "Attendance");

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
    }
}
