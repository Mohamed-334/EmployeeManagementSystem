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
    [Migration("20241204184135_AddEmplyeeRecordsAndUpdateTasksTableToJobs")]
    partial class AddEmplyeeRecordsAndUpdateTasksTableToJobs
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
                            Id = "d704b3ee-eea3-400f-8098-5550622262b6",
                            AccessFailedCount = 0,
                            Address = "Kafr AlShikh",
                            ConcurrencyStamp = "650707b3-8f20-461b-9259-bd52b9c4af7d",
                            Email = "mohamedaboelez334@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmk.1516",
                            PhoneNumber = "01068706845",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d738790f-597f-413f-9981-f0ab4250ce84",
                            TwoFactorEnabled = false,
                            UserName = "Mohamed Ibrahim"
                        },
                        new
                        {
                            Id = "361125fb-80f8-47c5-bbce-4c494b2ac9ca",
                            AccessFailedCount = 0,
                            Address = "Alex",
                            ConcurrencyStamp = "2d9eb852-279b-4582-8341-339b210ca349",
                            Email = "Youssef1234.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmkTany.1516",
                            PhoneNumber = "01049834561",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cb943d8f-5057-4fe6-a9d0-56a59b396aa9",
                            TwoFactorEnabled = false,
                            UserName = "Youssef Ibrahim"
                        },
                        new
                        {
                            Id = "b7289caf-e8a0-41fb-9e6a-d7d3008f03e7",
                            AccessFailedCount = 0,
                            Address = "Alex",
                            ConcurrencyStamp = "390dc8a5-367c-4624-b1ab-a9e1d16e1f4b",
                            Email = "Khaled333@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmkTalet.1516",
                            PhoneNumber = "0118735194",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "3aac502a-9f29-4ebc-816e-042db3cef657",
                            TwoFactorEnabled = false,
                            UserName = "Khaled Alaa"
                        },
                        new
                        {
                            Id = "0621d553-4789-4590-abdb-0b598b7b1122",
                            AccessFailedCount = 0,
                            Address = "Alex",
                            ConcurrencyStamp = "4560b8ac-1292-443e-a2a9-5d3a5680a0f2",
                            Email = "AnasMohamed784.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmk4.1516",
                            PhoneNumber = "01249834561",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "eb6a7f4b-603c-401b-91a2-b6352094cb3d",
                            TwoFactorEnabled = false,
                            UserName = "Anas Mohamed"
                        },
                        new
                        {
                            Id = "75fe677f-3dc7-42f2-8e64-c4388b941de6",
                            AccessFailedCount = 0,
                            Address = "Kafr AlShikh",
                            ConcurrencyStamp = "ce911478-3bd8-45be-a64e-96c4c10ae844",
                            Email = "KhaledAhmed@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmk5.1516",
                            PhoneNumber = "01532943571",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "029f4744-262a-4343-83cf-583515abf942",
                            TwoFactorEnabled = false,
                            UserName = "Khaled Ahmed    "
                        },
                        new
                        {
                            Id = "867ddd36-2437-41d0-8f6a-073c2cdf9328",
                            AccessFailedCount = 0,
                            Address = "Alex",
                            ConcurrencyStamp = "ca395d81-6383-4425-ac5a-e768aa22673d",
                            Email = "Alaa841.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "EntaMalOmkTany.1516",
                            PhoneNumber = "0107835641",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cba62b83-a20f-470b-9eb6-4012ee58bca7",
                            TwoFactorEnabled = false,
                            UserName = "Alaa Osama"
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
                            Id = 1,
                            DeadLine = new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Done = false,
                            TaskDescription = "Create Login Page For the Employee System",
                            TaskName = "LoginPage"
                        },
                        new
                        {
                            Id = 2,
                            DeadLine = new DateTime(2025, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Done = false,
                            TaskDescription = "Create Page that Hold Related Cars Photos",
                            TaskName = "Photo Package Page"
                        },
                        new
                        {
                            Id = 3,
                            DeadLine = new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Done = false,
                            TaskDescription = "Create Register Page For the Employee System",
                            TaskName = "Register Page"
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

                    b.ToTable("AspNetRoles", (string)null);
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

                    b.ToTable("AspNetUserRoles", (string)null);
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