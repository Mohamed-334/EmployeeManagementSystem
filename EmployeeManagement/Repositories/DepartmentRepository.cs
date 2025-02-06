using EmployeeManagementDatabase.Data;
using EmployeeManagementDatabase.Entities;
using Repositories.Factory;
using Repositories.Interfaces;

namespace Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext context = AppDbContextFactory.Create();
        public void Add(Department entity)
        {
            context.Departments.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Department entity)
        {
            context.Departments.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Department> GetAll() => context.Departments.ToList();

        public IEnumerable<Department> GetByForeignKey(Func<Department, bool> filter) => context.Departments.Where(filter).ToList();
        public Department GetById(int id) => context.Departments.Find(id);
        public void Update(Department entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
