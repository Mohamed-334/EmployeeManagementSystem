using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class AddNotificationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NotificationMessage = table.Column<string>(type: "VarChar(255)", maxLength: 255, nullable: false),
                    NotificationDate = table.Column<DateTime>(type: "Date", nullable: false),
                    Seen = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK_Notification_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Notification_EmployeeId",
                table: "Notification",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e732627b-ee21-46c6-8c9e-a108bc93b13b", "5a0c1b1e-c9d9-4a1f-85ab-232bc47538e0" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "eb2e367d-918d-4091-91b8-deadf32046d0", "e0bea192-0f2a-45b2-b5ea-eb5b8eedc11d" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "732e1c63-4db3-46e9-a694-0795fe2677d6", "b7958993-213e-4692-9f37-0d8d7710b039" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0d85847d-b1a8-4478-88dd-95e34b39b74b", "9fa13b23-c192-40de-ac9a-b472a71deae7" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6ee45e3-c3d1-4849-8503-514a37a20755", "e741aebd-d0a0-4f9a-b2b2-8b03feed57eb" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de523c4a-43d3-4f8e-a26f-e1c0e08270ef", "1eedc62d-3fbe-4aa5-b18d-640b356f3c94" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ecfbee31-30b4-4b0d-8d9e-443f6a68cf81", "17695888-b249-4dca-9a2e-25ea69046e9c" });
        }
    }
}
