using EmployeeManagementDatabase.Entities;

namespace EmployeeManagementDB.Entities
{
    public class MailSeen
    {
        public int Id { get; set; }
        public int MailId { get; set; }
        public string EmployeeId { get; set; }
        public bool Seen { get; set; } = false;
        public virtual Employee Employee { get; set; }
        public virtual Report Report { get; set; }
    }
}
