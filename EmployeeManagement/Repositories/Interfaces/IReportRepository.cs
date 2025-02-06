using EmployeeManagementDatabase.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interfaces
{
    public interface IReportRepository : IRepository<Report , int> , IGetByForeignKeyRepository<Report> , IGetTotalRecordsNumber 
    {
        int NumberOfReportsLastYear();
        int NumberOfReportsLastMonth();
        int NumberOfOwnReports(string id);
        decimal PercentageOfReportsGenerated(string id);

    }
}
