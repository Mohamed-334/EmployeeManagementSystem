using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class AddGlobalFilterQuery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b1421964-de17-4b3a-abe8-2f709cb288a9", "66d4219a-8d83-4e7e-bbb0-92eed768d53d" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f326d5b9-8490-4ff7-b829-3c9588aebb7b", "be0243e0-22f4-4121-bea9-509e8d078f30" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9047107e-3e0c-4bd1-8a15-badc65b4d294", "c6d42e0a-7031-40ae-836e-6d08c41c3cf1" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "732a9f82-c505-4b08-b203-5e5c7fc56285", "91a2c143-c87e-4653-a9b1-bd0a9f6ddbbb" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f001fa07-04f3-424d-846e-df40b83c5dfd", "dc8a4881-ec08-4cde-93af-1575bf76c0ed" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6f41080a-fd5b-4cbd-95b8-6b9bc356b887", "596cb460-fe1a-45f2-82f4-2ce37fbfcf05" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c364e178-04f4-47ae-9db5-faa3b1a51b15", "1c89d1a4-de6a-4cf0-890c-de21f9e93089" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "89258cdd-8c7d-4181-90ca-c0e6abea81f9", "d0a7ca90-849f-4509-a035-aef1d34bc765" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "efe34c29-0e53-4966-8f6d-9e5f0a48b390", "f8762e3e-a85d-4e0c-8645-7810770de99a" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ca0f02e1-ed8a-4713-a0dd-58a5a6479009", "34a71a5e-b8d5-45ed-ae08-5a5c3c9534ad" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00fa160a-2b12-4344-a7d7-9d88ec1165fc", "f71c3dac-f392-4015-91f8-46575f7b172a" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d00a8dde-941f-4eec-ba34-9781b33a28e8", "1e864e27-b781-47e9-a904-2f85faa72f1d" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ed971574-f4e2-4b71-afe0-c413650ebf06", "8a0d133d-ff95-480a-92e2-43403a23075b" });

            migrationBuilder.UpdateData(
                table: "Employee",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5e368f00-916c-4d01-aea8-f3cda0436944", "9b3212cc-a160-49fe-9f03-4496ba4510f0" });
        }
    }
}
