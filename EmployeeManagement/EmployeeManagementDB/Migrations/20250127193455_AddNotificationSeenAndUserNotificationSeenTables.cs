using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class AddNotificationSeenAndUserNotificationSeenTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Seen",
                table: "Notification");

            migrationBuilder.CreateTable(
                name: "NotificationSeen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationId = table.Column<int>(type: "int", nullable: false),
                    Seen = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationSeen", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserNotificationSeen");

            migrationBuilder.DropTable(
                name: "NotificationSeen");

            migrationBuilder.AddColumn<bool>(
                name: "Seen",
                table: "Notification",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4d1c3aad-d1a2-46c1-b6ff-3821c8658e29", "21282c0e-decf-4bfc-ba3c-816886b4cd98" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6c6631be-d459-404b-b69a-f2f485643136", "f4506758-8677-4358-af9a-5bcdff5811c8" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "03ea2a7e-599c-48df-ade3-24461ee8df5e", "48680944-59be-407b-83fa-54828ebe64d5" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "70afa318-ac27-4bcf-b506-6dab8d61d3c9", "264a127c-12d2-4367-9856-c8e94624ae59" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d04b55d5-c8bb-43b5-bf9b-be4f1da4432d", "08e22de9-8254-4806-9f84-5634d5be3351" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5bb68dd6-80fc-4760-9bc2-f6e906a34468", "be7533da-a98e-4c15-8cdd-10272a6e7987" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc5de73d-f18a-498e-b4fd-4752c9dad2cb", "d0930252-b7e5-4d7d-bc03-2c29563be01c" });
        }
    }
}
