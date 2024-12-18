using EmployeeManagementDatabase.Entities;
using Repositories.Enum;

namespace Repositories.Repo_Tracker
{
    public class EmployeeSnapshot
    {
        public TrackerState RepositoryState { get; set; }
        public Employee Data { get; set; }
        public DateTime At { get; set; } = DateTime.Now;    

    }
}
