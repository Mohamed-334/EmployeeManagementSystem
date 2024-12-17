using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementDatabase.Entities
{
    public class EmployeeAttendance
    {
        public int Id { get; set; }
        public string? EmployeeId { get; set; }
        public string Day { get; set; }
        public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public TimeSpan StartTime { get; set;} 
        public TimeSpan EndTime { get; set; }
        [NotMapped]
        public bool IsStarted { get; set; }
        [NotMapped]
        public bool IsEnded { get; set; }

        public virtual Employee? Employee { get; set; }
    }
}