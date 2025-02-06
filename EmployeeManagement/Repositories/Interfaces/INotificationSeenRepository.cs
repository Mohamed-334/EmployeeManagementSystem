using EmployeeManagementDB.Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface INotificationSeenRepository : IRepository<NotificationSeen , int>
    {
         long GetUserUnseenNotificationsCount(string UserId);
         IEnumerable<Notification> GetUserUnseenNotifications(string UserId);
         NotificationSeen GetByNotification(int NotificationId , string UserID);
    }
}
