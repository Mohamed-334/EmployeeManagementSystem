using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class AddEmployeePhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "09934387-b480-4e26-8caf-f4c1fe795ef7", "2917c226-3385-41a8-99c3-6228e1692c44" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "14d67842-748c-49eb-bbaa-a6d6e97d2641", "8920b8aa-6d4f-4462-8773-a65f0b25bc47" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d8941ff8-f97a-4602-8d69-8130b54f2389", "eeeb0891-ed80-48bf-81c2-693dbe1e8b78" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "432d5ebe-07e4-4f66-af59-6df8b7bea377", "77f6df3d-0358-4529-a73a-8a670a1e72df" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d2435d24-c8e6-4198-b44f-e26963f0ffcd", "034af2e7-a633-4d32-8102-1d5e942baea7" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "201ad61f-b51f-4d23-997a-d64cd9d7163d", "f33119b6-5ca3-46bd-8b7b-c730f0c166a8" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b6117e6c-bcbe-449c-a53c-ff4fabc28bde", "07f27d66-7ef3-4bae-8960-09499da61d35" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "51821910-0f67-414f-be16-98547c3f47e4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "4291bc09-c4b4-424d-aef1-01af65fb60b4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3c46c5af-53aa-472d-9df0-97134f7dcf4f", "4a179484-0964-43f6-87c6-e4b52bc71d6a" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a2461792-9b48-4781-9c51-1f305ae23b67", "fa0901bf-5435-49fc-bb7f-d302e4b1fa28" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9bb7ca73-fa9f-4e57-98b7-0626e651da2e", "f340d3a3-8809-4d51-872f-1515c24541ce" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "644cf6bd-a483-4fb2-b5dc-307bfbc804e7", "7e2baa53-f80f-4639-8d28-b818d6dacdbe" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3cc69ad9-8de1-4ce5-941a-983fdb653add", "7bf600c5-3b66-4468-ab9a-a46b61b7fb03" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de682d9c-0b29-4b14-8068-115813cc52d4", "5d44c07d-786f-4cf7-9f6f-7fe29cbd485c" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1a032157-556d-4369-853a-638b99eb4db4", "7246a777-a84e-45d1-9743-7377202f4009" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b96ea46f-f7c0-4838-b984-229483a88ce4");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "701a0434-e71e-4c09-b224-460a9e6c5fe9");
        }
    }
}
