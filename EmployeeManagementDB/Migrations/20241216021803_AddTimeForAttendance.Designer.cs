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
    [Migration("20241216021803_AddTimeForAttendance")]
    partial class AddTimeForAttendance
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

                    b.HasKey("Id");

                    b.ToTable("Departments", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 2,
                            DepartmentName = "Back-end",
                            EmployeeId = "1"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentName = "Front-end",
                            EmployeeId = "4"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentName = "Adminstration",
                            EmployeeId = "7"
                        });
                });

            modelBuilder.Entity("EmployeeManagementDatabase.Entities.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int?>("PositionId")
                        .HasColumnType("int");

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

                    b.HasIndex("PositionId");

                    b.ToTable("Employees", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1",
                            AccessFailedCount = 0,
                            Address = "Assuit",
                            ConcurrencyStamp = "29335551-c897-4d9c-96ee-3cfd3bb5e658",
                            DepartmentId = 2,
                            Email = "mohamedaboelez334@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Mohamed",
                            LastName = "Ibrahim",
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmk.1516",
                            PhoneNumber = "01068706845",
                            PhoneNumberConfirmed = false,
                            PositionId = 1,
                            SecurityStamp = "651e7535-d536-4a1f-8759-79a49480656e",
                            TwoFactorEnabled = false,
                            UserName = "MohamedIbrahim"
                        },
                        new
                        {
                            Id = "2",
                            AccessFailedCount = 0,
                            Address = "Sharm AlSheikh",
                            ConcurrencyStamp = "be60e69d-432f-4963-983b-75e48cb64243",
                            DepartmentId = 3,
                            Email = "Youssef1234.com",
                            EmailConfirmed = false,
                            FirstName = "Youssef",
                            LastName = "Ibrahim",
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmkTany.1516",
                            PhoneNumber = "01049834561",
                            PhoneNumberConfirmed = false,
                            PositionId = 2,
                            SecurityStamp = "c4c943b3-9d6c-4424-b01f-d74cf816eda6",
                            TwoFactorEnabled = false,
                            UserName = "YoussefIbrahim"
                        },
                        new
                        {
                            Id = "3",
                            AccessFailedCount = 0,
                            Address = "Cairo",
                            ConcurrencyStamp = "b598973a-5c38-4ba1-8625-c8d4444ae6a9",
                            DepartmentId = 4,
                            Email = "Khaled333@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Khaled",
                            LastName = "Alaa",
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmkTalet.1516",
                            PhoneNumber = "0118735194",
                            PhoneNumberConfirmed = false,
                            PositionId = 3,
                            SecurityStamp = "6393e922-cd94-4cac-9a32-ce19c1b55ebf",
                            TwoFactorEnabled = false,
                            UserName = "KhaledAlaa"
                        },
                        new
                        {
                            Id = "4",
                            AccessFailedCount = 0,
                            Address = "New Capital",
                            ConcurrencyStamp = "19565749-0b0a-4ffa-afef-6ce3dfa2069c",
                            DepartmentId = 5,
                            Email = "AnasMohamed784.com",
                            EmailConfirmed = false,
                            FirstName = "Anas",
                            LastName = "Mohamed",
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmk4.1516",
                            PhoneNumber = "01249834561",
                            PhoneNumberConfirmed = false,
                            PositionId = 4,
                            SecurityStamp = "4f2d4093-7288-4976-a4e9-104807c47b73",
                            TwoFactorEnabled = false,
                            UserName = "AnasMohamed"
                        },
                        new
                        {
                            Id = "5",
                            AccessFailedCount = 0,
                            Address = "Alex",
                            ConcurrencyStamp = "e2abbf13-752b-430c-98aa-ac01a7bef08a",
                            DepartmentId = 2,
                            Email = "KhaledAhmed@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Khaled",
                            LastName = "Ahmed",
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmk5.1516",
                            PhoneNumber = "01532943571",
                            PhoneNumberConfirmed = false,
                            PositionId = 5,
                            SecurityStamp = "cb55095a-865d-41ce-a4a2-867c81002fda",
                            TwoFactorEnabled = false,
                            UserName = "KhaledAhmed"
                        },
                        new
                        {
                            Id = "6",
                            AccessFailedCount = 0,
                            Address = "Kafr Alsheikh",
                            ConcurrencyStamp = "5bbc7501-01c4-4eac-a7c4-0fc1cd1d653e",
                            DepartmentId = 4,
                            Email = "Alaa841.com",
                            EmailConfirmed = false,
                            FirstName = "Alaa",
                            LastName = "Osama",
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmkTany.1516",
                            PhoneNumber = "0107835641",
                            PhoneNumberConfirmed = false,
                            PositionId = 6,
                            SecurityStamp = "13038552-1ba0-4747-9dbb-06aafc2c14b4",
                            TwoFactorEnabled = false,
                            UserName = "AlaaOsama"
                        },
                        new
                        {
                            Id = "7",
                            AccessFailedCount = 0,
                            Address = "Alex",
                            ConcurrencyStamp = "c4f9a4b1-f848-4681-9d93-30a51b09620b",
                            Email = "Admin1@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "1",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN1",
                            PasswordHash = "AQAAAAEAACcQAAAAENRk/0rWj9s9DDgr3hBGlpYR1MG2yXRFRtxLnu3B8Oh4sNCuukNQ9+wp5e7KseC8eA==",
                            PhoneNumber = "01068873164",
                            PhoneNumberConfirmed = false,
                            PositionId = 7,
                            SecurityStamp = "489d36b9-eba1-4bf2-a01a-d01183351dad",
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

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("Time");

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

                    b.Property<DateTime>("At")
                        .HasColumnType("Date");

                    b.Property<string>("EmployeeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("VacationType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Vacations", (string)null);
                });

            modelBuilder.Entity("EmployeeManagementDB.Entities.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("PositionName")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("positions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 2,
                            PositionName = "DotNet Developer"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            PositionName = "PM Back-end"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 2,
                            PositionName = "Laravel Developer"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 4,
                            PositionName = "React Developer"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 4,
                            PositionName = "Angular Developer"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 4,
                            PositionName = "PM Front-end "
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 6,
                            PositionName = "Admin"
                        });
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
                            ConcurrencyStamp = "a2108885-2a45-4898-99a1-7ec3540aa94d",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "2",
                            ConcurrencyStamp = "3740b702-1f80-4e43-9f14-214a6e5432d1",
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

                    b.HasOne("EmployeeManagementDB.Entities.Position", "Position")
                        .WithMany("Employees")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Department");

                    b.Navigation("Position");
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
                        .HasForeignKey("EmployeeId");

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

            modelBuilder.Entity("EmployeeManagementDB.Entities.Position", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
