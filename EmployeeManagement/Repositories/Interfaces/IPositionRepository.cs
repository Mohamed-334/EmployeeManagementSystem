using EmployeeManagementDB.Entities;
using Repository;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IPositionRepository : IRepository<Position , int> , IGetByForeignKeyRepository<Position>
    {
    }
}
