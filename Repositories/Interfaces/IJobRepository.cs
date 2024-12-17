using EmployeeManagementDatabase.Entities;

namespace Repository.Interfaces
{
    public interface IJobRepository : IRepository<Job , int> , IGetByForeignKeyRepository<Job , string>,IGetTopRecords<Job> , IGetTotalRecordsNumber
    {
        decimal GetCompletedTaskPercentage();
        int GetTotalCompletedTasks();
    }
}
