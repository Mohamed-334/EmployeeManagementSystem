using EmployeeManagementDatabase.Data;
using EmployeeManagementDatabase.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Repositories;
using Repositories.Interfaces;
using Repository;
using Repository.Interfaces;

namespace EmployeeManagementSystemWebSite
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IJobRepository, JobRepository>();
            builder.Services.AddScoped<IReportRepository, ReportRepository>();
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            builder.Services.AddScoped<IPositionRepository, PositionRepository>();
            builder.Services.AddScoped<IVacationRepository, VacationRepository>();
            builder.Services.AddScoped<IAttendanceRepository, AttendanceRepository>();
            builder.Services.AddScoped<INotificationRepository, NotificationRepository>();
            builder.Services.AddScoped<INotificationSeenRepository, NotificationSeenRepository>();
            builder.Services.AddScoped<IMailSeenRepository, MailSeenRepository>();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseLazyLoadingProxies();
                opt.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeManagementSystem"));
            }) ;
            builder.Services.AddIdentity<Employee, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();
            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();


            
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Account}/{action=OpenTheDashboard}/{id?}");

            app.Run();
        }
    }
}