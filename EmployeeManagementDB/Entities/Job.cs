using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementDatabase.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public string? EmployeeId { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public bool Done { get; set; }
        // [DataType(DataType.Date)]
        // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}" , ApplyFormatInEditMode =true)]
        public DateOnly DeadLine { get; set; }

        public virtual Employee? Employee { get; set; }
    }
}