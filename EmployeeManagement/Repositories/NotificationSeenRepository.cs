using EmployeeManagementDatabase.Data;
using EmployeeManagementDB.Entities;
using Repositories.Factory;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class NotificationSeenRepository : INotificationSeenRepository
    {
        private readonly AppDbContext context = AppDbContextFactory.Create();
        public void Add(NotificationSeen entity)
        {
            context.Add(entity);    
            context.SaveChanges();
        }

        public void Delete(NotificationSeen entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<NotificationSeen> GetAll() => context.NotificationSeens.ToList();

        public NotificationSeen GetById(int id) =>  context.NotificationSeens is null? new NotificationSeen() : context.NotificationSeens.First(e => e.Id == id);

        public void Update(NotificationSeen entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
        public long GetUserUnseenNotificationsCount(string UserId) =>  context.NotificationSeens.Where(u => u.EmployeeId == UserId && u.Seen == false).Count();

        public IEnumerable<Notification> GetUserUnseenNotifications(string UserId)
        {
            var Outer = context.NotificationSeens.Where(u => u.EmployeeId == UserId && u.Seen == false);
            var Inner = context.Notifications;
            return Inner.Join(Outer, e => e.NotificationId, e => e.NotificationId, (inner , outer) => inner);
        }

        public NotificationSeen GetByNotification(int NotificationId , string UserId) => context.NotificationSeens.First(n => n.NotificationId == NotificationId && n.EmployeeId == UserId);
    }
}
