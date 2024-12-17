using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    public partial class AddPositionsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "PositionId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PositionName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_positions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "7a2e56ef-39d0-4e3c-8906-e28b77a0a617");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "201be277-11c9-4fdf-bb04-4abe079adb03");

            migrationBuilder.InsertData(
                table: "positions",
                columns: new[] { "Id", "DepartmentId", "PositionName" },
                values: new object[,]
                {
                    { 1, 2, "DotNet Developer" },
                    { 2, 2, "PM Back-end" },
                    { 3, 2, "Laravel" },
                    { 4, 4, "React" },
                    { 5, 4, "Angular" },
                    { 6, 4, "PM Front-end " },
                    { 7, 6, "Admin" }
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PositionId", "SecurityStamp" },
                values: new object[] { "4d210bad-3d5f-4845-ade9-dc80f65d611b", 1, "8a314e11-3978-4c41-8b45-cd61657dff4e" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PositionId", "SecurityStamp" },
                values: new object[] { "d384c3e7-75f6-4d4d-b4ac-f54a33aecc54", 2, "2c340439-6dd6-48b5-95ea-db1d6b407c41" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PositionId", "SecurityStamp" },
                values: new object[] { "848e7c88-ea8d-42a2-afe2-b9e13dd89ff4", 3, "a699f3bc-9ffc-41e3-b640-95d30aeb7c28" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PositionId", "SecurityStamp" },
                values: new object[] { "f5ccabb7-d840-4ebc-a11e-399c52b16ee0", 4, "10cc05fd-e370-4e6a-8da3-c5bf6d375cdf" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PositionId", "SecurityStamp" },
                values: new object[] { "f9d77bad-7e43-453b-bf61-c6186289a949", 5, "a644240f-c7dc-44cf-bf09-b6d6c29eb065" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PositionId", "SecurityStamp" },
                values: new object[] { "d9d6cda4-b2aa-498f-a357-df0742c24d35", 6, "b1866c1d-d058-4b98-a04d-ffec13103e5f" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "ConcurrencyStamp", "PositionId", "SecurityStamp" },
                values: new object[] { "ad0eb2b1-ec03-4d46-b8d3-67097072d2a3", 7, "894e7535-1b1e-4526-a9ba-3d26991ddd0d" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PositionId",
                table: "Employees",
                column: "PositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_positions_PositionId",
                table: "Employees",
                column: "PositionId",
                principalTable: "positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_positions_PositionId",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "positions");

            migrationBuilder.DropIndex(
                name: "IX_Employees_PositionId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "PositionId",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Departments",
                type: "Varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Position",
                value: "Dot Net Dev");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Position",
                value: "React");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Position",
                value: "Admin");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "DepartmentName", "EmployeeId", "Position" },
                values: new object[,]
                {
                    { 3, "Back-end", "2", "Laravel" },
                    { 5, "Front-end", "5", "Angular" }
                });

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
    }
}
