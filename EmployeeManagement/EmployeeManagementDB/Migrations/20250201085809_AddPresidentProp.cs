using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class AddPresidentProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DepartmentPresident",
                table: "Department",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2,
                column: "DepartmentPresident",
                value: null);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 4,
                column: "DepartmentPresident",
                value: null);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 6,
                column: "DepartmentPresident",
                value: null);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 7,
                column: "DepartmentPresident",
                value: null);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 8,
                column: "DepartmentPresident",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b32dd7b1-78db-4530-8f8b-4d7d02e69a41", "b2f8cbae-97e0-45f6-a61e-de6d30a8f968" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6db78a7d-38aa-4f68-8d16-b7c51a88d440", "44486c75-8a05-4a87-bf63-5d779f0cb988" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "05fd75da-62de-4d1c-bd2a-707ab512addc", "b73c6529-52bf-47e2-8182-d540dbb3159f" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4ead16c7-695e-4741-9ab1-96e4d488d287", "9220dc97-a707-474d-a545-ea2abc1314cd" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ec688f5a-2454-4ef8-a16a-9bcca58471a6", "8d739266-4bb7-4551-ba31-1db8a50a4e98" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "46baf66b-bfa3-4eb4-a0bb-2c41ccc73c28", "2677f808-892d-4de4-a128-03a9dc9bbaf9" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4920e2de-18f4-403d-b0d9-04514ff576b4", "193dbef4-1074-4204-b895-566d8e0cf376" });

            migrationBuilder.CreateIndex(
                name: "IX_position_PositionName",
                table: "position",
                column: "PositionName",
                unique: true,
                filter: "[PositionName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Department_DepartmentName",
                table: "Department",
                column: "DepartmentName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_DepartmentPresident",
                table: "Department",
                column: "DepartmentPresident",
                unique: true,
                filter: "[DepartmentPresident] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employee_DepartmentPresident",
                table: "Department",
                column: "DepartmentPresident",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employee_DepartmentPresident",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_position_PositionName",
                table: "position");

            migrationBuilder.DropIndex(
                name: "IX_Department_DepartmentName",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_DepartmentPresident",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "DepartmentPresident",
                table: "Department");

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5f4f8394-e54f-46ae-a14f-26a6db1ce744", "79afab2f-81e9-409a-abe3-7bdc4f9461b6" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0b839967-36dc-4b97-9e54-61670455de03", "aefa630c-c629-409b-8171-0f6692227574" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e0c98ff2-ff4b-4a54-a87c-09d4b45adaa1", "6eaf547c-4f01-4c1b-b4b0-e5be40b2c9ad" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d039dc9c-8988-49ff-b97a-cfce3562cac3", "c4ac57ed-d6c9-4086-b0d1-8e09635ed76c" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d891e256-e436-4062-a963-01f0704cef32", "2580eb64-0d46-4c1d-9043-2dc65106da0b" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ddea5c0d-27aa-4e22-a5c6-d0bc15bd2eb4", "3a59b3f2-0124-46cd-a57d-a98100e70ce9" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8f66a5f1-e79d-46f9-83b7-65d7232334f8", "d08ca34f-85ed-4ffc-8cb3-546e348a5c83" });
        }
    }
}
