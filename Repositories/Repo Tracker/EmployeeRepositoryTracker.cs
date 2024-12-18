using EmployeeManagementDatabase.Entities;
using Repositories.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repo_Tracker
{
    public class EmployeeRepositoryTracker
    {
        private static EmployeeRepositoryTracker Tracker;

        private static List<EmployeeSnapshot> EmployeeSnapshots;

        private EmployeeRepositoryTracker()
        {
        }

        public static EmployeeRepositoryTracker GetInstance()
        {
            if(Tracker is null)
            {
                EmployeeSnapshots = new List<EmployeeSnapshot>();
                return new EmployeeRepositoryTracker();
            }
            else 
               return Tracker;
        }

        public void AddSnapshot(TrackerState state , Employee Data  )
        {
            EmployeeSnapshots.Add(new EmployeeSnapshot
            {
                RepositoryState = state,
                Data = Data
            });
        }

        public List<EmployeeSnapshot> GetAllSnapshots() => EmployeeSnapshots;
    } 
}
