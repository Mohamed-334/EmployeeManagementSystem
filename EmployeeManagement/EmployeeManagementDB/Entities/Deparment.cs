using EmployeeManagementDB.Entities;
using System.Text.Json.Serialization;

namespace EmployeeManagementDatabase.Entities
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string? DepartmentPresident { get; set; }

        [JsonIgnore]
        public virtual ICollection<Position> Positions { get; set; }
        public virtual Employee President { get; set; }
    }
}