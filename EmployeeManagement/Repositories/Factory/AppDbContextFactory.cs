using EmployeeManagementDatabase.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Factory
{
    public class AppDbContextFactory
    {
        public static AppDbContext Create() => new AppDbContext();
    }
}
