using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDatabase.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public string? EmployeeId { get; set; }
        public string ReportHeader { get; set; }
        public string ReportBody { get; set; }
        public DateOnly SendAt { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public virtual Employee? Employee { get; set; }
    }
}
