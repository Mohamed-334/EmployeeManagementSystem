﻿using EmployeeManagementDatabase.Entities;
using Repository;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IVacationRepository : IRepository<Vacation , int> , IGetByForeignKeyRepository<Vacation , string>
    {
    }
}