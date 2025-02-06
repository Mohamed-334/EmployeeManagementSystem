using EmployeeManagementDatabase.Data;
using EmployeeManagementDB.Entities;
using Repositories.Factory;
using Repositories.Interfaces;

namespace Repository
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly AppDbContext context = AppDbContextFactory.Create();

        public void Add(Notification entity)
        {
            context.Notifications.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Notification entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }
        public IEnumerable<Notification> GetAll() => context.Notifications is null ? new List<Notification>() : context.Notifications.ToList();

        public IEnumerable<Notification> GetByForeignKey(Func<Notification, bool> filter) => context.Notifications is null? new List<Notification>() : context.Notifications.Where(filter).ToList();
        public Notification GetById(int id)
        {
            var Notification = context.Notifications.Find(id);
            return Notification is null ? new Notification() : Notification;
        }

        /*public IEnumerable<Notification> GetUnSeenNotifications() => context.Notifications.Where(n => n.Seen == false);

        public long GetUnSeenNotificationsCount() => context.Notifications.Where(n=> n.Seen == false).Count();

        public IEnumerable<Notification> GetUnSeenUserNotifications(string UserId) => context.Notifications.Where(n => n.EmployeeId == UserId && n.Seen == false);

        public long GetUnSeenUserNotificationsCount(string UserId) => context.Notifications.Where(n => n.EmployeeId == UserId && n.Seen == false ).Count();*/
        public void Update(Notification entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
