using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class SeedingDataToReportTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e37cf59e-0ffe-4e11-90c6-4b681091ae58", "22cf54dd-8681-4e81-895d-54918cfca9df" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f021e8bb-5915-4e7d-8ded-1be61ab2e28a", "71baf8b7-4628-440d-a702-93a57d59040f" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d35c58e6-86b6-437e-9604-01ca53619c46", "d65a9474-7c5b-45ce-8fc6-9eb196a612ac" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f3bc8c92-f4a8-4806-aa61-a624b8d6b612", "0c50f2b6-1e4b-4d49-bff2-3baba93b857e" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "824b747c-0849-4dcb-ae04-455da00daa5c", "86a95861-8388-4174-bdf0-bab067ccf1f1" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7fdb41f3-8671-4218-a562-302c35f187dd", "43dfc4a6-ffb5-4973-9ec6-776f3b1a45fd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fda92436-05b2-44a3-9040-45125ea444a7", "4079eda2-6d95-4543-b80b-2d7fc6e9e6a1" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d32e0c62-b6d7-4a7f-8622-69dbd6518d67", "45d698cd-7375-4f1a-9471-a16af95dfdff" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4cb317ba-123a-42fa-89a5-c5ea8ac65d30", "7ace33fb-7fc2-4de3-a565-32ec97333405" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "680ee951-da71-410c-b556-bb1784a5ee99", "38a331a9-d422-4e96-88bd-b15c3c13d04a" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fef1bd90-8c3c-4e5f-b320-358685f7d781", "f7f9d12b-ef9c-42fe-86b9-9f23533af8d4" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e6b7128a-1323-4353-af1a-0b13814c19b0", "6489a2cc-1fbb-4c1d-b5bc-ddab5adffcdc" });
        }
    }
}
