using EmployeeManagementDatabase.Entities;
using Repositories.Interfaces;

namespace Repository.Interfaces
{
    public interface IJobRepository : IRepository<Job , int> , IGetByForeignKeyRepository<Job >,IGetTopRecords<Job> , IGetTotalRecordsNumber , IGetTopRecordsByForeignKey<Job>
    {
        decimal GetCompletedTaskPercentage();
        int GetTotalCompletedTasks();
        
    }
}
