using EmployeeManagementDB.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementDatabase.Entities
{
    public class Employee : IdentityUser //<int>
    {
        public string FirstName  { get; set; }
        public string LastName  { get; set; }
        public string Address  { get; set; }
        public int? DepartmentId { get; set; }
        public int? PositionId { get; set; }
        public byte[]? ProfilePhoto { get; set; }
        [NotMapped]
        public string FullName {
            get
            {
                return $"{FirstName} {this.LastName}";
            }
            set
            {
            }
        }
        [NotMapped]
        public bool AttendanceFlag { get; set; }


        public virtual Position Position { get; set; }
        public  virtual Department? Department { get; set; }
        public  virtual ICollection<Vacation> Vacations { get; set; }
        public  virtual ICollection<Job> Tasks { get; set; }
        public  virtual ICollection<Report> Reports { get; set; }
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