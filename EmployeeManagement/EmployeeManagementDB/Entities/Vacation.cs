using EmployeeManagementDatabase.Entities;
using EmployeeManagementDB.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDB.Entities
{
    public class Vacation
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }
        public VacationType VacationType { get; set; }
        public DateTime At { get; set; } = DateTime.Now;

        public virtual Employee? Employee { get; set; }
    }
}
