using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationBetweenNotificationAndUsers2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notification_Employee_EmployeeId",
                table: "Notification");

            migrationBuilder.DropIndex(
                name: "IX_Notification_EmployeeId",
                table: "Notification");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Notification");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Notification",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "143580a7-6d34-4e99-a283-dcfce0c78917", "e73fbf09-94a2-47cf-8424-c078fa61b873" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c61b3a3-432b-4586-9f7f-96ee6c2a3fc7", "17492a1c-6f1e-406f-a730-1d737665b98d" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f2ce852d-ea2f-4f08-94f3-397bc26ccb7e", "6d8af24a-6528-4a46-bda8-5c51b5429a2a" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7e9d23bc-97b2-4bd1-8874-8fd1cd44601a", "1906a5b1-1f2b-4e5b-b144-9c858f9be0ed" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "41f157a6-a43f-4bad-908c-e1193c459c68", "b6206441-65e0-448e-981a-fff49df0fac0" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "930272e4-e2b5-4b38-b990-38593b45b20a", "d979bbaf-83e7-4f69-9b44-b4cc82028a84" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bda8279b-82c5-4b3c-8bb2-d02c6298358e", "ecbd1196-8873-40bf-955a-27ce41f0a35a" });

            migrationBuilder.CreateIndex(
                name: "IX_Notification_EmployeeId",
                table: "Notification",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notification_Employee_EmployeeId",
                table: "Notification",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
