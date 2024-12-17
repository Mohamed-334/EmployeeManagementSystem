using EmployeeManagementDatabase.Enums;

namespace EmployeeManagementDatabase.Entities
{
    public class Vacation
    {
        public int Id { get; set; }
        public string? EmployeeId { get; set; }
        public Vacations VacationType { get; set; }
        public DateOnly At { get; set; } = DateOnly.FromDateTime(DateTime.Now);
        public virtual Employee? Employee { get; set; }

    }
}