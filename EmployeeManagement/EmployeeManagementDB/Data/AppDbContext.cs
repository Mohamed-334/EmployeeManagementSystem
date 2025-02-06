using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EmployeeManagementDatabase.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using System.Data;
using Converts;
using EmployeeManagementDatabase.Data.Config;
using EmployeeManagementDB.Entities;

namespace EmployeeManagementDatabase.Data
{
    public class AppDbContext : IdentityDbContext<Employee>
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<EmployeeAttendance> EmployeeAttendance { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationSeen> NotificationSeens { get; set; }
        public DbSet<MailSeen> MailSeens { get; set; }

        private DbContextOptions _options;
        public AppDbContext(){}
        public AppDbContext(DbContextOptions options)
        {
            _options = options;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                             .AddJsonFile("AppSettings.json")
                             .Build();
            string? cs = config.GetConnectionString("EmployeeManagementSystem");
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(cs);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(UserRolesConfiguration).Assembly);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            base.ConfigureConventions(configurationBuilder);
            configurationBuilder.Properties<DateOnly>()
               .HaveConversion<DateOnlyConverter>()
               .HaveColumnType("date");
        }
    }
}
