﻿// <auto-generated />
using System;
using EmployeeManagementDatabase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagementDatabase.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241208004627_SeedingUserRoleData")]
    partial class SeedingUserRoleData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeManagementDatabase.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Departments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 2,
                            DepartmentName = "Back-end",
                            EmployeeId = "1",
                            Position = "Dot Net Dev"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentName = "Back-end",
                            EmployeeId = "2",
                            Position = "Laravel"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentName = "Front-end",
                            EmployeeId = "4",
                            Position = "React"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentName = "Front-end",
                            EmployeeId = "5",
                            Position = "Angular"
                        });
                });

            modelBuilder.Entity("EmployeeManagementDatabase.Entities.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("VarChar(30)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("VarChar(30)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<byte[]>("ProfilePhoto")
                        .HasColumnType("Image");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Employees", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "14300794-9fc0-4125-a640-22b5a60dc601",
                            DepartmentId = 2,
                            Email = "mohamedaboelez334@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Mohamed",
                            LastName = "Ibrahim",
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmk.1516",
                            PhoneNumber = "01068706845",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2d6e2310-23da-4e85-9ea8-959214edaa46",
                            TwoFactorEnabled = false,
                            UserName = "MohamedIbrahim"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6404bb38-91b3-4ed2-9088-f5086e6d0b64",
                            DepartmentId = 3,
                            Email = "Youssef1234.com",
                            EmailConfirmed = false,
                            FirstName = "Youssef",
                            LastName = "Ibrahim",
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmkTany.1516",
                            PhoneNumber = "01049834561",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cc3497ae-40f3-409e-90a3-c5d481b5c758",
                            TwoFactorEnabled = false,
                            UserName = "YoussefIbrahim"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0aaf0c1e-9b52-41fc-8b7a-c6cf3796db5c",
                            DepartmentId = 4,
                            Email = "Khaled333@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Khaled",
                            LastName = "Alaa",
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmkTalet.1516",
                            PhoneNumber = "0118735194",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "27c765e5-debf-40b5-96f6-19927f1f952e",
                            TwoFactorEnabled = false,
                            UserName = "KhaledAlaa"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2bb9fde7-da43-4a65-ba01-1e2c7905bd89",
                            DepartmentId = 5,
                            Email = "AnasMohamed784.com",
                            EmailConfirmed = false,
                            FirstName = "Anas",
                            LastName = "Mohamed",
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmk4.1516",
                            PhoneNumber = "01249834561",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3d74382f-b268-49f4-a9a7-00252053819d",
                            TwoFactorEnabled = false,
                            UserName = "AnasMohamed"
                        },
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "cfbbbeab-a7b4-4cd7-bab8-19e708781aaa",
                            DepartmentId = 2,
                            Email = "KhaledAhmed@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Khaled",
                            LastName = "Ahmed",
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmk5.1516",
                            PhoneNumber = "01532943571",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1a591cf4-7548-4705-8181-13fe0453f3db",
                            TwoFactorEnabled = false,
                            UserName = "KhaledAhmed"
                        },
                        new
                        {
                            Id = "6",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a512d24a-1209-4adf-ab00-08b30b158278",
                            DepartmentId = 4,
                            Email = "Alaa841.com",
                            EmailConfirmed = false,
                            FirstName = "Alaa",
                            LastName = "Osama",
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmkTany.1516",
                            PhoneNumber = "0107835641",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "246628c2-3c1d-4525-99b8-83ac892a5de3",
                            TwoFactorEnabled = false,
                            UserName = "AlaaOsama"
                        },
                        new
                        {
                            Id = "7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "db42a2be-513e-449e-b1d0-490392f672fb",
                            Email = "Admin1@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "1",
                            LockoutEnabled = false,
                            PasswordHash = "Admin.11",
                            PhoneNumber = "01068873164",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4760eb1d-fe45-4b0f-bc3a-9e6a91a16c62",
                            TwoFactorEnabled = false,
                            UserName = "Admin1"
                        });
                });

            modelBuilder.Entity("EmployeeManagementDatabase.Entities.EmployeeAttendance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Attendance", (string)null);
                });

            modelBuilder.Entity("EmployeeManagementDatabase.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DeadLine")
                        .HasColumnType("Date");

                    b.Property<bool>("Done")
                        .HasColumnType("bit");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TaskDescription")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Jobs", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 6,
                            DeadLine = new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Done = false,
                            EmployeeId = "4",
                            TaskDescription = "Create Login Page For the Employee System",
                            TaskName = "LoginPage"
                        },
                        new
                        {
                            Id = 7,
                            DeadLine = new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Done = false,
                            EmployeeId = "5",
                            TaskDescription = "Create Page that Hold Related Cars Photos",
                            TaskName = "Photo Package Page"
                        },
                        new
                        {
                            Id = 8,
                            DeadLine = new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Done = false,
                            EmployeeId = "4",
                            TaskDescription = "Create Register Page For the Employee System",
                            TaskName = "Register Page"
                        },
                        new
                        {
                            Id = 9,
                            DeadLine = new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Done = false,
                            EmployeeId = "2",
                            TaskDescription = "Create back-end Login Page For the Employee System",
                            TaskName = " Back-end Login Page"
                        },
                        new
                        {
                            Id = 10,
                            DeadLine = new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Done = false,
                            EmployeeId = "1",
                            TaskDescription = "Create Back-end Register Page For the Employee System",
                            TaskName = "Back-end Register Page"
                        });
                });

            modelBuilder.Entity("EmployeeManagementDatabase.Entities.Report", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ReportBody")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("Varchar(255)")
                        .HasColumnName("Body");

                    b.Property<string>("ReportHeader")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("Varchar(30)")
                        .HasColumnName("Header");

                    b.Property<DateTime>("SendAt")
                        .HasColumnType("Date");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Reports", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = "3",
                            ReportBody = "Login Page has Been Completed",
                            ReportHeader = "Login Page",
                            SendAt = new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = "3",
                            ReportBody = " Back-end Login Page has Been Completed",
                            ReportHeader = "Back-end Login Page",
                            SendAt = new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("EmployeeManagementDatabase.Entities.Vacation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("EmployeeId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("VacationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Vacations", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            ConcurrencyStamp = "b808777b-49db-4a30-9303-4ec5ee50a365",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "9888bbb8-0723-4723-8e40-65325808a43d",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "7",
                            RoleId = "2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EmployeeManagementDatabase.Entities.Employee", b =>
                {
                    b.HasOne("EmployeeManagementDatabase.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Department");
                });

            modelBuilder.Entity("EmployeeManagementDatabase.Entities.EmployeeAttendance", b =>
                {
                    b.HasOne("EmployeeManagementDatabase.Entities.Employee", "Employee")
                        .WithMany("Attendances")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmployeeManagementDatabase.Entities.Job", b =>
                {
                    b.HasOne("EmployeeManagementDatabase.Entities.Employee", "Employee")
                        .WithMany("Tasks")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmployeeManagementDatabase.Entities.Report", b =>
                {
                    b.HasOne("EmployeeManagementDatabase.Entities.Employee", "Employee")
                        .WithMany("Reports")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("EmployeeManagementDatabase.Entities.Vacation", b =>
                {
                    b.HasOne("EmployeeManagementDatabase.Entities.Employee", "Employee")
                        .WithMany("Vacations")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EmployeeManagementDatabase.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EmployeeManagementDatabase.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EmployeeManagementDatabase.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EmployeeManagementDatabase.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EmployeeManagementDatabase.Entities.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("EmployeeManagementDatabase.Entities.Employee", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("Reports");

                    b.Navigation("Tasks");

                    b.Navigation("Vacations");
                });
#pragma warning restore 612, 618
        }
    }
}
