using EmployeeManagementDatabase.Entities;
using EmployeeManagementDB.Entities;
using Repositories.DTO;

namespace Repositories.Interfaces
{
    public interface IMailSeenRepository : IRepository<MailSeen, int>
    {
        long GetUserUnseenMailsCount(string UserId);
        IEnumerable<ReportDTO> GetUserMails(string UserId);
        MailSeen GetByMailId(int NotificationId,string UserId);
    }
}
