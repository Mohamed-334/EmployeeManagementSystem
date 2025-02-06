using EmployeeManagementDatabase.Entities;

namespace EmployeeManagementDB.Entities
{
    public class NotificationSeen
    {
        public int Id { get; set; }
        public int NotificationId { get; set; }
        public bool Seen { get; set; } = false;
        public string EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Notification Notification { get; set; }
    }
}
