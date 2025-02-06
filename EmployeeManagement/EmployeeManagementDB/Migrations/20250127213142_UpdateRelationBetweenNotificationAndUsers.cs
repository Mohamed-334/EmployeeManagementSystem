using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRelationBetweenNotificationAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserNotificationSeen");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "NotificationSeen",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                name: "IX_NotificationSeen_EmployeeId",
                table: "NotificationSeen",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationSeen_NotificationId",
                table: "NotificationSeen",
                column: "NotificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationSeen_Employee_EmployeeId",
                table: "NotificationSeen",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationSeen_Notification_NotificationId",
                table: "NotificationSeen",
                column: "NotificationId",
                principalTable: "Notification",
                principalColumn: "NotificationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotificationSeen_Employee_EmployeeId",
                table: "NotificationSeen");

            migrationBuilder.DropForeignKey(
                name: "FK_NotificationSeen_Notification_NotificationId",
                table: "NotificationSeen");

            migrationBuilder.DropIndex(
                name: "IX_NotificationSeen_EmployeeId",
                table: "NotificationSeen");

            migrationBuilder.DropIndex(
                name: "IX_NotificationSeen_NotificationId",
                table: "NotificationSeen");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "NotificationSeen",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.CreateTable(
                name: "UserNotificationSeen",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NotificationId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NotificationsSeenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNotificationSeen", x => new { x.UserId, x.NotificationId });
                    table.ForeignKey(
                        name: "FK_UserNotificationSeen_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNotificationSeen_NotificationSeen_NotificationsSeenId",
                        column: x => x.NotificationsSeenId,
                        principalTable: "NotificationSeen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4a74cf62-4114-47b3-9419-a0ee2f09786c", "2a058dcc-a5f7-4c53-a79e-706ca06295b0" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "75218dc1-bc12-458d-aae5-7a78d82e3716", "b82b64e4-7dd0-4739-b2e5-908c0b2d0ca2" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7b67265b-05d4-4fd4-8f1d-d0882d98d074", "50a94860-6168-40ce-b414-d21a6f4c7467" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "39d11923-3cad-4242-8641-a58fd17f7cf8", "b7ec0dd3-40dd-422d-a363-1ec2f8645058" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a554189a-a947-46f7-8607-e9ec315c647c", "ce17855c-b078-4f99-80a5-8603bc14115e" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "496b5616-2ace-4ed1-84f0-7e657f1de29c", "3f676331-0cef-439c-ab5c-10b9cb15b9da" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "06f2b7db-c989-4868-ac68-a966cbe9783b", "de74201d-c2c1-4940-b2d1-ce70391c466f" });

            migrationBuilder.CreateIndex(
                name: "IX_UserNotificationSeen_EmployeeId",
                table: "UserNotificationSeen",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserNotificationSeen_NotificationsSeenId",
                table: "UserNotificationSeen",
                column: "NotificationsSeenId");
        }
    }
}
