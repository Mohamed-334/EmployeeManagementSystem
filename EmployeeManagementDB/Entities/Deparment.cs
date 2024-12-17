using EmployeeManagementDB.Entities;

namespace EmployeeManagementDatabase.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string? EmployeeId { get; set; }
        public string DepartmentName { get; set; }


        public virtual ICollection<Employee> Employees { get; set; }
    }
}