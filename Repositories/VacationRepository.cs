using EmployeeManagementDatabase.Data;
using EmployeeManagementDatabase.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class VacationRepository : IVacationRepository
    {
        private readonly AppDbContext context = new();
        public void Add(Vacation entity)
        {
            context.Vacations.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Vacation entity)
        {
            context.Vacations.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Vacation> GetAll() => context.Vacations.ToList();

        public IEnumerable<Vacation> GetByForeignKey(string ForeinKey) => context.Vacations.Where(v => v.EmployeeId == ForeinKey).ToList();
        public Vacation GetById(int id) => context.Vacations.Find(id);
        public void Update(Vacation entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
