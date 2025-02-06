using EmployeeManagementDatabase.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee , string> , IGetTopRecords<Employee> , IGetTotalRecordsNumber  , IGetTopRecordsByForeignKey<Employee>
        ,IGetByForeignKeyRepository<Employee>
    {
        decimal GetEmployeesNotAssignedToDepartment();
        IEnumerable<Employee> GetEmployees();
        IEnumerable<Employee> GetManagers();
        IEnumerable<Employee> GetAdmins();
    }
}
