using EmployeeManagementDatabase.Enums;
using EmployeeManagementDB.Validation_Attributes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EmployeeManagementDatabase.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public string? EmployeeId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string? TaskLink { get; set; }
        public Enums.TaskState State { get; set; } = Enums.TaskState.Running;
        // [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}" , ApplyFormatInEditMode =true)]
        [DeadLineChecker()]
        public DateTime DeadLine { get; set; }
        [JsonIgnore]
        public virtual Employee? Employee { get; set; }
        public virtual ICollection<Report>? Reports { get; set; }
    }
}