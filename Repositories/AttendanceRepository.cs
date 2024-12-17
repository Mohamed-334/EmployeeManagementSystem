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
    public class AttendanceRepository : IAttendanceRepository
    {
        private readonly AppDbContext context = new();
        public void Add(EmployeeAttendance entity)
        {
            context.EmployeeAttendance.Add(entity);
            context.SaveChanges();
        }

        public void Delete(EmployeeAttendance entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<EmployeeAttendance> GetAll() => context.EmployeeAttendance.ToList();

        public EmployeeAttendance GetById(int id) => context.EmployeeAttendance.FirstOrDefault(x => x.Id == id);

        public void Update(EmployeeAttendance entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
    }
}
