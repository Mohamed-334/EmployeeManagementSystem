using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class UpdateEmpData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "babd7923-bf69-4248-861e-ebf0be618b24", "f1457348-a529-4c1f-a4d5-da28d6dad42c" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cbfe90ab-5e98-41a6-9672-134324332573", "573ab0bd-3042-42cb-9ec5-5d0edbe61f88" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7a6267fc-a906-43b8-85a9-498d238840e9", "f6dff72f-7b8d-4b85-8cc7-44485ab7d0bc" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e6aa89e-5d45-42d4-a352-97de580d4fa6", "45d171c3-f15d-4100-ac03-b96ba9661c45" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e68fd4d-8941-4c45-af34-69d9170664b0", "70cced9f-86a4-4020-91ae-866306b032ae" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ac1e96b7-9fd8-471e-a39a-777e2ab1c9ca", "8718a988-32cc-4f93-90f4-809d09f7431a" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53520095-9d95-4d01-8f04-796a793c8a54", "ADMIN@GMAIL.COM", "ADMIN1", "Admin.123", "37d15f31-2123-4369-9d93-1d6ea5b162d4" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6a373cfc-0f94-4426-b16a-fb0d5f7d6e7b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1052b71d-0588-4d36-b565-c08b5dcc39f1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "14300794-9fc0-4125-a640-22b5a60dc601", "2d6e2310-23da-4e85-9ea8-959214edaa46" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6404bb38-91b3-4ed2-9088-f5086e6d0b64", "cc3497ae-40f3-409e-90a3-c5d481b5c758" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0aaf0c1e-9b52-41fc-8b7a-c6cf3796db5c", "27c765e5-debf-40b5-96f6-19927f1f952e" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2bb9fde7-da43-4a65-ba01-1e2c7905bd89", "3d74382f-b268-49f4-a9a7-00252053819d" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cfbbbeab-a7b4-4cd7-bab8-19e708781aaa", "1a591cf4-7548-4705-8181-13fe0453f3db" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a512d24a-1209-4adf-ab00-08b30b158278", "246628c2-3c1d-4525-99b8-83ac892a5de3" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db42a2be-513e-449e-b1d0-490392f672fb", null, null, "Admin.11", "4760eb1d-fe45-4b0f-bc3a-9e6a91a16c62" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b808777b-49db-4a30-9303-4ec5ee50a365");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "9888bbb8-0723-4723-8e40-65325808a43d");
        }
    }
}
