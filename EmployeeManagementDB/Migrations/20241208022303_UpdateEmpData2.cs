using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class UpdateEmpData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1e199ad9-dd31-4b75-94b4-339be352ddff", "cfe09a68-27be-4137-b0d6-38d95513e0df" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e712e384-fdfa-46ee-b600-f4877affb0a9", "497615b1-1d0a-4d2c-a46e-d20b65ba9345" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e42000bb-a013-4530-9a28-74fca846f17e", "a5e714bb-51aa-41e9-84f4-326b2b9070c0" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76f18044-c580-4911-a1a1-d50a7a635b8f", "39736ff2-9192-4e0b-9797-8b0bb6d83496" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ee3a4b20-949e-47a6-b40b-1fe963eeb09b", "5cdd1050-439b-42a2-a323-27f896a62506" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "695be5ee-17ad-43cc-86cd-18d2c6295d16", "4d08495d-6632-42f9-965b-e82a810d4d7b" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76afdac9-9413-4df7-9241-106944e0dd1d", "AQAAAAEAACcQAAAAENRk/0rWj9s9DDgr3hBGlpYR1MG2yXRFRtxLnu3B8Oh4sNCuukNQ9+wp5e7KseC8eA==", "e94adb7f-0329-498f-b302-fd905085a40c" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "30ae2eba-158f-48e6-b875-12c6eb3bb281");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4ed71722-f034-4547-95fb-1162a9e71eac");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53520095-9d95-4d01-8f04-796a793c8a54", "Admin.123", "37d15f31-2123-4369-9d93-1d6ea5b162d4" });

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
    }
}
