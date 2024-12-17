using EmployeeManagementDatabase.Data;
using EmployeeManagementDB.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private readonly AppDbContext context = new();

        public void Add(Position entity)
        {
            context.Positions.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Position entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Position> GetAll() => context.Positions.ToList();

        public IEnumerable<Position> GetByForeignKey(int ForeinKey) => context.Positions.Where(e => e.DepartmentId == ForeinKey).ToList();

        public Position GetById(int id) => context.Positions.Find(id);

        public void Update(Position entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
