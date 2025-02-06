using EmployeeManagementDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IGetTopRecordsByForeignKey<T> where T : class
    {
        IEnumerable<T> GetTopRecordsByForeignKey(int Records, Func<T,bool> condition);
    }
}
