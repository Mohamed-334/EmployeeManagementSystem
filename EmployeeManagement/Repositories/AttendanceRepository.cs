using EmployeeManagementDatabase.Data;
using EmployeeManagementDB.Entities;
using Repositories.Factory;
using Repositories.Interfaces;

namespace Repositories
{
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly AppDbContext context = AppDbContextFactory.Create();
        public void Add(EmployeeAttendance entity)
        {
            context.EmployeeAttendance.Add(entity);
            context.SaveChanges();
        }

        public void Delete(EmployeeAttendance entity)
        {
            context.EmployeeAttendance.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<EmployeeAttendance> GetAll() => context.EmployeeAttendance.ToList();

        public IEnumerable<EmployeeAttendance> GetByForeignKey(Func<EmployeeAttendance, bool> filter) => context.EmployeeAttendance.Where(filter).ToList();
        public EmployeeAttendance GetById(int id) => context.EmployeeAttendance.Find(id);
        public void Update(EmployeeAttendance entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
