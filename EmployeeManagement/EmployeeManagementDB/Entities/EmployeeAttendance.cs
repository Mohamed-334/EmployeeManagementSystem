using EmployeeManagementDatabase.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDB.Entities
{
    public class EmployeeAttendance
    {
        public int Id { get; set; }
        public string? EmployeeId { get; set; }
        public string Day { get; set; }
        public DateOnly Date { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public TimeSpan TotalTimeWork { get; set; }
        public string State { get; set; }

        [NotMapped]
        public bool IsEnded { get; set; } = false;
        [NotMapped]
        public bool IsStarted { get; set; } = false;
        public virtual Employee Employee { get; set; }
    }
}
