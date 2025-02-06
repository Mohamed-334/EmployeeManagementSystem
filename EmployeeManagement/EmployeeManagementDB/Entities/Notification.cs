using EmployeeManagementDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDB.Entities
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public string NotificationMessage { get; set; }
        public DateTime NotificationDate { get; set; } = DateTime.Now;
        public virtual ICollection<NotificationSeen> UserNotification { get; set; }
    }
}
