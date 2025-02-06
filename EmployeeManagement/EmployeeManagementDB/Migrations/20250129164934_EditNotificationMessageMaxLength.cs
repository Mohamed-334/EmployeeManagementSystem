using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class EditNotificationMessageMaxLength : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "Report",
                type: "Varchar(Max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "NotificationMessage",
                table: "Notification",
                type: "VarChar(Max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(255)",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89258cdd-8c7d-4181-90ca-c0e6abea81f9", "d0a7ca90-849f-4509-a035-aef1d34bc765" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "efe34c29-0e53-4966-8f6d-9e5f0a48b390", "f8762e3e-a85d-4e0c-8645-7810770de99a" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca0f02e1-ed8a-4713-a0dd-58a5a6479009", "34a71a5e-b8d5-45ed-ae08-5a5c3c9534ad" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00fa160a-2b12-4344-a7d7-9d88ec1165fc", "f71c3dac-f392-4015-91f8-46575f7b172a" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d00a8dde-941f-4eec-ba34-9781b33a28e8", "1e864e27-b781-47e9-a904-2f85faa72f1d" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed971574-f4e2-4b71-afe0-c413650ebf06", "8a0d133d-ff95-480a-92e2-43403a23075b" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e368f00-916c-4d01-aea8-f3cda0436944", "9b3212cc-a160-49fe-9f03-4496ba4510f0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Body",
                table: "Report",
                type: "Varchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "Varchar(Max)");

            migrationBuilder.AlterColumn<string>(
                name: "NotificationMessage",
                table: "Notification",
                type: "VarChar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(Max)");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ad6eb528-c1fd-4a9c-9639-716ae6343a24", "cbe7a04f-7ea6-4411-a8a7-ac28712e9757" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "decba6a6-cd8e-46b6-b28d-408da176e87c", "00fac582-d36d-4d52-9244-7fecd53bffb4" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "107123f9-d118-4d0c-90d5-9e4ecdc29ac1", "a566a141-8111-47ba-8509-837484746408" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9bb59da0-20a4-4da6-b548-0cb3f768af31", "6dd8003e-6013-4810-aa33-5588ffed0679" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1df61230-1796-47fb-84c5-1454933b8b88", "eabf4252-9e68-4eff-93c7-b939ef186866" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1458c353-43b2-4973-9568-2ee0f6080497", "d37c01ff-6ed2-438e-97b7-74ff1190d78f" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0e7611d7-6d59-4f1e-b3c1-b99b239c18d6", "328529c2-128c-45d0-af19-ac6ef40aa1f4" });
        }
    }
}
