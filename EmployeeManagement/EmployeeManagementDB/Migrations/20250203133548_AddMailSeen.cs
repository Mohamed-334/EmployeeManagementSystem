using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class AddMailSeen : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacation_Employee_EmployeeId",
                table: "Vacation");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Vacation",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartTime",
                table: "Attendance",
                type: "time",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "Time");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EndTime",
                table: "Attendance",
                type: "time",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "Time");

            migrationBuilder.AlterColumn<string>(
                name: "Day",
                table: "Attendance",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Attendance",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.CreateTable(
                name: "MailSeen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MailId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Seen = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailSeen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MailSeen_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MailSeen_Report_MailId",
                        column: x => x.MailId,
                        principalTable: "Report",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_MailSeen_EmployeeId",
                table: "MailSeen",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_MailSeen_MailId",
                table: "MailSeen",
                column: "MailId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacation_Employee_EmployeeId",
                table: "Vacation",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacation_Employee_EmployeeId",
                table: "Vacation");

            migrationBuilder.DropTable(
                name: "MailSeen");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Vacation",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "StartTime",
                table: "Attendance",
                type: "Time",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "EndTime",
                table: "Attendance",
                type: "Time",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "time");

            migrationBuilder.AlterColumn<string>(
                name: "Day",
                table: "Attendance",
                type: "varchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Attendance",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b32dd7b1-78db-4530-8f8b-4d7d02e69a41", "b2f8cbae-97e0-45f6-a61e-de6d30a8f968" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6db78a7d-38aa-4f68-8d16-b7c51a88d440", "44486c75-8a05-4a87-bf63-5d779f0cb988" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "05fd75da-62de-4d1c-bd2a-707ab512addc", "b73c6529-52bf-47e2-8182-d540dbb3159f" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ead16c7-695e-4741-9ab1-96e4d488d287", "9220dc97-a707-474d-a545-ea2abc1314cd" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec688f5a-2454-4ef8-a16a-9bcca58471a6", "8d739266-4bb7-4551-ba31-1db8a50a4e98" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46baf66b-bfa3-4eb4-a0bb-2c41ccc73c28", "2677f808-892d-4de4-a128-03a9dc9bbaf9" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4920e2de-18f4-403d-b0d9-04514ff576b4", "193dbef4-1074-4204-b895-566d8e0cf376" });

            migrationBuilder.AddForeignKey(
                name: "FK_Vacation_Employee_EmployeeId",
                table: "Vacation",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");
        }
    }
}
