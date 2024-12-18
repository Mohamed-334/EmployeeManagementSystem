using EmployeeManagementDatabase.Data;
using EmployeeManagementDatabase.Entities;
using Repositories.Factory;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext context = AppDbContextFactory.Create();
        public void Add(Department entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Department entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Department> GetAll() => context.Departments.ToList();

        public Department GetById(int id) => context.Departments.Find(id);

        public void Update(Department entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
