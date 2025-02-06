using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagementDB.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "position",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    PositionName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_position", x => x.Id);
                    table.ForeignKey(
                        name: "FK_position_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "VarChar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "VarChar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionId = table.Column<int>(type: "int", nullable: true),
                    ManagerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ProfilePhoto = table.Column<byte[]>(type: "Image", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employee_Employee_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Employee_position_PositionId",
                        column: x => x.PositionId,
                        principalTable: "position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_Employee_UserId",
                        column: x => x.UserId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_Employee_UserId",
                        column: x => x.UserId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_Employee_UserId",
                        column: x => x.UserId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Day = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "Time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "Time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendance_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TaskName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    TaskDescription = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeadLine = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Job_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_Employee_UserId",
                        column: x => x.UserId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vacation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    VacationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    At = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vacation_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Report",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromEmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ToEmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TaskId = table.Column<int>(type: "int", nullable: true),
                    Header = table.Column<string>(type: "Varchar(30)", maxLength: 30, nullable: false),
                    Body = table.Column<string>(type: "Varchar(255)", maxLength: 255, nullable: false),
                    ReportType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SendAt = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Report", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Report_Employee_FromEmployeeId",
                        column: x => x.FromEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Report_Employee_ToEmployeeId",
                        column: x => x.ToEmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Report_Job_TaskId",
                        column: x => x.TaskId,
                        principalTable: "Job",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "DepartmentName" },
                values: new object[,]
                {
                    { 2, "Back-end" },
                    { 4, "Front-end" },
                    { 6, "Adminstration" },
                    { 7, "Tech Management" },
                    { 8, "Finans Management" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Employee", "EMPLOYEE" },
                    { "2", null, "Admin", "ADMIN" },
                    { "3", null, "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "position",
                columns: new[] { "Id", "DepartmentId", "PositionName" },
                values: new object[,]
                {
                    { 1, 2, "DotNet Developer" },
                    { 2, 7, "PM Back-end" },
                    { 3, 2, "Laravel Developer" },
                    { 4, 4, "React Developer" },
                    { 5, 4, "Angular Developer" },
                    { 6, 7, "PM Front-end " },
                    { 7, 6, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "ManagerId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PositionId", "ProfilePhoto", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "Assuit", "e732627b-ee21-46c6-8c9e-a108bc93b13b", "mohamedaboelez334@gmail.com", false, "Mohamed", "Ibrahim", false, null, null, null, null, "EntaMalOmk.1516", "01068706845", false, 1, null, "5a0c1b1e-c9d9-4a1f-85ab-232bc47538e0", false, "MohamedIbrahim" },
                    { "2", 0, "Sharm AlSheikh", "eb2e367d-918d-4091-91b8-deadf32046d0", "Youssef1234.com", false, "Youssef", "Ibrahim", false, null, null, null, null, "EntaMalOmkTany.1516", "01049834561", false, 2, null, "e0bea192-0f2a-45b2-b5ea-eb5b8eedc11d", false, "YoussefIbrahim" },
                    { "3", 0, "Cairo", "732e1c63-4db3-46e9-a694-0795fe2677d6", "Khaled333@gmail.com", false, "Khaled", "Alaa", false, null, null, null, null, "EntaMalOmkTalet.1516", "0118735194", false, 3, null, "b7958993-213e-4692-9f37-0d8d7710b039", false, "KhaledAlaa" },
                    { "4", 0, "New Capital", "0d85847d-b1a8-4478-88dd-95e34b39b74b", "AnasMohamed784.com", false, "Anas", "Mohamed", false, null, null, null, null, "EntaMalOmk4.1516", "01249834561", false, 4, null, "9fa13b23-c192-40de-ac9a-b472a71deae7", false, "AnasMohamed" },
                    { "5", 0, "Alex", "e6ee45e3-c3d1-4849-8503-514a37a20755", "KhaledAhmed@gmail.com", false, "Khaled", "Ahmed", false, null, null, null, null, "EntaMalOmk5.1516", "01532943571", false, 5, null, "e741aebd-d0a0-4f9a-b2b2-8b03feed57eb", false, "KhaledAhmed" },
                    { "6", 0, "Kafr Alsheikh", "de523c4a-43d3-4f8e-a26f-e1c0e08270ef", "Alaa841.com", false, "Alaa", "Osama", false, null, null, null, null, "EntaMalOmkTany.1516", "0107835641", false, 6, null, "1eedc62d-3fbe-4aa5-b18d-640b356f3c94", false, "AlaaOsama" },
                    { "7", 0, "Alex", "ecfbee31-30b4-4b0d-8d9e-443f6a68cf81", "Admin1@gmail.com", false, "Admin", "1", false, null, null, "ADMIN@GMAIL.COM", "ADMIN1", "AQAAAAEAACcQAAAAENRk/0rWj9s9DDgr3hBGlpYR1MG2yXRFRtxLnu3B8Oh4sNCuukNQ9+wp5e7KseC8eA==", "01068873164", false, 7, null, "17695888-b249-4dca-9a2e-25ea69046e9c", false, "Admin1" }
                });

            migrationBuilder.InsertData(
                table: "Job",
                columns: new[] { "Id", "DeadLine", "EmployeeId", "State", "TaskDescription", "TaskName" },
                values: new object[,]
                {
                    { 6, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", "Running", "Create Login Page For the Employee System", "LoginPage" },
                    { 7, new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "5", "Running", "Create Page that Hold Related Cars Photos", "Photo Package Page" },
                    { 8, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", "Running", "Create Register Page For the Employee System", "Register Page" },
                    { 9, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "2", "Running", "Create back-end Login Page For the Employee System", " Back-end Login Page" },
                    { 10, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "1", "Running", "Create Back-end Register Page For the Employee System", "Back-end Register Page" }
                });

            migrationBuilder.InsertData(
                table: "Report",
                columns: new[] { "Id", "FromEmployeeId", "Body", "Header", "ReportType", "SendAt", "TaskId", "ToEmployeeId" },
                values: new object[,]
                {
                    { 1, "7", "Login Page has Been Completed", "Login Page", "DeliverTask", new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "3" },
                    { 2, "7", " Back-end Login Page has Been Completed", "Back-end Login Page", "DeliverTask", new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "3" }
                });

            migrationBuilder.InsertData(
                table: "UserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "7" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendance_EmployeeId",
                table: "Attendance",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Employee",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ManagerId",
                table: "Employee",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_PositionId",
                table: "Employee",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Employee",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Job_EmployeeId",
                table: "Job",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_position_DepartmentId",
                table: "position",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_FromEmployeeId",
                table: "Report",
                column: "FromEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_TaskId",
                table: "Report",
                column: "TaskId");

            migrationBuilder.CreateIndex(
                name: "IX_Report_ToEmployeeId",
                table: "Report",
                column: "ToEmployeeId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Vacation_EmployeeId",
                table: "Vacation",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "Report");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Vacation");

            migrationBuilder.DropTable(
                name: "Job");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "position");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
