using EmployeeManagementDB.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementDatabase.Entities
{
    public class Employee : IdentityUser 
    {
        public string FirstName  { get; set; }
        public string LastName  { get; set; }
        public string Address  { get; set; }
        public int? PositionId { get; set; }
        public string? ManagerId { get; set; }
        public byte[] ProfilePhoto { get; set; }
        [NotMapped]
        public string FullName => $"{FirstName} {this.LastName}";
        [NotMapped]
        public bool AttendanceFlag { get; set; }

        public  virtual Position Position { get; set; }
        public  virtual Employee? Manager { get; set; }
        public  virtual Department? Department { get; set; }
        public virtual ICollection<NotificationSeen> UserNotification { get; set; }
        public virtual ICollection<MailSeen> MailSeen { get; set; }
        public virtual ICollection<Employee> EmployeesOfManager { get; set; }
        public  virtual ICollection<Vacation> Vacations { get; set; }
        public  virtual ICollection<Job> Tasks { get; set; }
        public  virtual ICollection<Report> FromReports { get; set; }
        public  virtual ICollection<Report> ToReports { get; set; }
        public  virtual ICollection<EmployeeAttendance> Attendances { get; set; }

    }
    [NotMapped]
    public class EmployeeRole 
    {
        public Employee employee { get; set; }
        public string  RoleName { get; set; }
        public string  RoleId { get; set; }
    }
}