using EmployeeManagementDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee , string> , IGetTopRecords<Employee> , IGetTotalRecordsNumber
    {
        decimal GetEmployeesNotAssignedToDepartment();
        IEnumerable<Employee> GetEmployees();
        IEnumerable<Employee> GetAdmins();
    }
}
