using EmployeeManagementDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EmployeeManagementDB.Entities
{
    public  class Position
    {
        public int Id { get; set; }
        public int? DepartmentId { get; set; }
        public string PositionName { get; set; }
        [JsonIgnore]
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual Department Department { get; set; }

    }
}
