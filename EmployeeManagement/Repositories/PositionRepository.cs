using EmployeeManagementDatabase.Data;
using EmployeeManagementDatabase.Entities;
using EmployeeManagementDB.Entities;
using Repositories.Factory;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private readonly AppDbContext context = AppDbContextFactory.Create();

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

        public IEnumerable<Position> GetByForeignKey(Func<Position, bool> filter) => context.Positions.Where(filter).ToList();

        public Position GetById(int id) => context.Positions.Find(id);

        public void Update(Position entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
