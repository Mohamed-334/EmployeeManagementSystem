using EmployeeManagementDB.Entities;
using System.Text.Json.Serialization;

namespace EmployeeManagementDatabase.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string? EmployeeId { get; set; }
        public string DepartmentName { get; set; }

        [JsonIgnore]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}