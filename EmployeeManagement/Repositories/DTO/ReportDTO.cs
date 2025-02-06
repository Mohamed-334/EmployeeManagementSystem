using EmployeeManagementDatabase.Entities;
using EmployeeManagementDatabase.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.DTO
{
    public class ReportDTO
    {
        public Report Report { get; set; }
        public bool Seen { get; set; }
    }
}
