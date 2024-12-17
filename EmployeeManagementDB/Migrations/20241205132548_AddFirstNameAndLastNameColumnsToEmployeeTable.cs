using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class AddFirstNameAndLastNameColumnsToEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "24061ff7-e8c8-458b-a24f-07819abf4819");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "d99e9eb9-7259-4ae1-8611-56a6816d84cf");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "VarChar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "VarChar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "62bb5f91-b819-4333-84eb-e417759436ad", "Mohamed", "Ibrahim", "0b31b743-b4a2-4aff-b64b-14855e32cc17", "MohamedIbrahim" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "03e2f964-225a-42bd-987d-a1f67a0d08e1", "Youssef", "Ibrahim", "c93eef6d-4258-4e10-a624-a1973c90f5d7", "YoussefIbrahim" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "19feba17-538e-4ca3-be33-0b85900807cc", "Khaled", "Alaa", "fe062e2a-367c-4ca3-8089-f91383f679bb", "KhaledAlaa" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "193f4d48-119a-438c-a2be-945c0ebf5cd2", "Anas", "Mohamed", "85dbd35f-e7b4-43cb-b63d-4c1d7ce9b917", "AnasMohamed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "2edf7b3a-daae-4dd6-aabb-c885272d9373", "Khaled", "Ahmed", "ecd2a514-9c97-4025-abc9-9fcef3b44c21", "KhaledAhmed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "SecurityStamp", "UserName" },
                values: new object[] { "1f0902ff-9c9f-4eca-8346-c495b1d8b63a", "Alaa", "Osama", "2979524d-55da-4e20-9a76-f4a484577ad3", "AlaaOsama" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f2cc6a1f-f080-4a3c-ad06-5ee07eb7064d", "ef76cf36-21e3-4a4b-b93f-95a98d319cfb", "Admin", "ADMIN" },
                    { "f677dffb-c8bc-4f61-8379-c7940c7eb261", "a985d2cd-f59b-4bee-98cd-18c265851e86", "Employee", "EMPLOYEE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f2cc6a1f-f080-4a3c-ad06-5ee07eb7064d");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "f677dffb-c8bc-4f61-8379-c7940c7eb261");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "Address", "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "Kafr AlShikh", "8a620223-cec2-4ceb-aaa5-2204b85813e4", "ffd5fa4b-d985-4319-a4f2-a24ac76cd673", "Mohamed Ibrahim" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Address", "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "Alex", "2e30f298-acc2-4871-9d40-f1c95691bfb5", "d1a8a558-53b7-4bf5-ad43-4784d5c66dae", "Youssef Ibrahim" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Address", "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "Alex", "e6f20955-2bc3-4121-80c9-ff73fadcc15c", "d4d17861-3eb4-4ae4-9ecc-8409b0d54597", "Khaled Alaa" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Address", "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "Alex", "553530d5-248b-4160-968d-c189893fffeb", "bb7ccab2-bc20-4c78-8a81-b9cdb4bb3f61", "Anas Mohamed" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Address", "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "Kafr AlShikh", "becd3464-1443-45d1-9e08-f2f965ea2bf8", "f90faa43-3326-4fe0-af0a-d7f4225ed2fe", "Khaled Ahmed    " });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "Address", "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "Alex", "15b82756-570c-4ee6-9e99-86af88dce874", "cc8b2136-2368-4be9-b32b-22ab12b85ba8", "Alaa Osama" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24061ff7-e8c8-458b-a24f-07819abf4819", "98324262-929a-4330-ab63-47bb33b07845", "Admin", "ADMIN" },
                    { "d99e9eb9-7259-4ae1-8611-56a6816d84cf", "fe1d1199-e064-4eaf-8913-9578d9325473", "Employee", "EMPLOYEE" }
                });
        }
    }
}
