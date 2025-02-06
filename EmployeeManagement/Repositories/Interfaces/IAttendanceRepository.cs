using EmployeeManagementDB.Entities;
using Repository.Interfaces;

namespace Repositories.Interfaces
{
    public interface IAttendanceRepository : IRepository<EmployeeAttendance, int>, IGetByForeignKeyRepository<EmployeeAttendance>
    {
    }
}
