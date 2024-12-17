using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class AddAddressColumnForEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Employees_EmployeeId",
                table: "Vacations");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Vacations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
                columns: new[] { "Address", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "Assuit", "89514ca9-b011-4649-a40d-4ccee62f398b", "e061934a-4a7c-42ff-b4c9-4a14233aac26" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "Address", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "Sharm AlSheikh", "901a7574-2fc4-42c5-90df-a1cdc0cc988f", "50b3a87b-0832-44ea-88f7-9654cb3735e0" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "Address", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "Cairo", "7f0a7477-b0b2-41cb-af6a-d0bdef39ba35", "c48274c5-b59e-4bb4-af01-cb465aa8e7d3" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "Address", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "New Capital", "42bfd88b-d826-4863-93c5-6217cfa0af19", "6b6d1b43-2403-4578-b00e-de90a140eb54" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "Address", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "Alex", "089706e5-a4d0-4437-8d8a-d00eccb925fb", "aac26ba4-8dd1-441e-bd95-058c0d2c978b" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "Address", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "Kafr Alsheikh", "53408197-a995-446f-bbde-8657b80364eb", "f34cfc14-daf7-4698-a8a1-1ced55bf7201" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "Address", "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "Alex", "b614ff6e-8b75-4f22-9429-5cae171ca090", "63904fda-75d2-4ce5-aeb6-11736bcfb4f5" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "eb165421-571f-4029-9884-d976c709f35a");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7807cea5-42ff-4d38-821b-9e9ea947aabc");

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Employees_EmployeeId",
                table: "Vacations",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Employees_EmployeeId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Vacations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "76afdac9-9413-4df7-9241-106944e0dd1d", "e94adb7f-0329-498f-b302-fd905085a40c" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Employees_EmployeeId",
                table: "Vacations",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
