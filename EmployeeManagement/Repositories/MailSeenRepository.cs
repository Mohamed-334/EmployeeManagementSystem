using EmployeeManagementDatabase.Data;
using EmployeeManagementDatabase.Entities;
using EmployeeManagementDB.Entities;
using Repositories.DTO;
using Repositories.Factory;
using Repositories.Interfaces;

namespace Repositories
{
    public class MailSeenRepository : IMailSeenRepository
    {
        private readonly AppDbContext context = AppDbContextFactory.Create();
        public void Add(MailSeen entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(MailSeen entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<MailSeen> GetAll() => context.MailSeens.ToList();

        public MailSeen GetById(int id) => context.MailSeens is null ? new MailSeen() : context.MailSeens.First(e => e.Id == id);

        public void Update(MailSeen entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
        public long GetUserUnseenMailsCount(string UserId) => context.MailSeens.Where(u => u.EmployeeId == UserId && u.Seen == false).Count();

        public IEnumerable<ReportDTO> GetUserMails(string UserId)
        {
            var Outer = context.MailSeens.Where(u => u.EmployeeId == UserId);
            var Inner = context.Reports;
            return Inner.Join(Outer, e => e.Id, e => e.MailId, (inner, outer) => new ReportDTO
            {
                Report = inner,
                Seen = outer.Seen,
            }) is null? new List<ReportDTO>() : Inner.Join(Outer, e => e.Id, e => e.MailId, (inner, outer) => new ReportDTO
            {
                Report = inner,
                Seen = outer.Seen,
            }).ToList();
        }

        public MailSeen GetByMailId(int MailId , string UserId) => context.MailSeens.First(n => n.MailId == MailId && n.EmployeeId == UserId );
    }
}
