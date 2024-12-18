using EmployeeManagementDatabase.Data;
using EmployeeManagementDatabase.Entities;
using Microsoft.AspNetCore.Identity;
using Repositories.Enum;
using Repositories.Factory;
using Repositories.Repo_Tracker;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context = AppDbContextFactory.Create();
        private readonly EmployeeRepositoryTracker Tracker = EmployeeRepositoryTracker.GetInstance();

        public void Add(Employee entity)
        {
            context.Employees.Add(entity);
            context.SaveChanges();
            Tracker.AddSnapshot(TrackerState.Add, entity);
        }

        public void Delete(Employee entity)
        {
            context.Remove(entity);
            context.SaveChanges();
            Tracker.AddSnapshot(TrackerState.Delete, entity);
        }

        public IEnumerable<Employee> GetAdmins()
        {
            var UserRoles = context.UserRoles;
            var AllEmployees = context.Employees;
            var EmpyeloesRoles = UserRoles.Join(AllEmployees,
                e => e.UserId,
                r => r.Id,
                (r, e) =>
                new EmployeeRole { employee = e, RoleId = r.RoleId });

            var AdminUsers = context.Roles.Join(EmpyeloesRoles
                , r => r.Id,
                e => e.RoleId,
                (r, e) =>
                new EmployeeRole { RoleName = r.Name, employee = e.employee })
                .Where(e => e.RoleName == "Admin")
                .Select(e => e.employee).ToList();

            return AdminUsers;
        }

        public IEnumerable<Employee> GetAll() => context.Employees.ToList();

        public Employee GetById(string id) 
        {
            var Employee = context.Employees.Find(id);
            Tracker.AddSnapshot(TrackerState.RetreiveById, Employee);
            return Employee;
        }

        public IEnumerable<Employee> GetEmployees() 
        {
            var UserRoles = context.UserRoles;
            var AllEmployees = context.Employees;
            var EmpyeloesRoles = UserRoles.Join(AllEmployees, 
                e => e.UserId,
                r => r.Id, 
                (r,e) =>
                new EmployeeRole {employee = e, RoleId = r.RoleId});

            var AdminUsers = context.Roles.Join(EmpyeloesRoles
                , r => r.Id,
                e => e.RoleId,
                (r, e) =>
                new EmployeeRole { RoleName = r.Name, employee = e.employee })
                .Where(e => e.RoleName == "Employee")
                .Select(e => e.employee).ToList();
            return AdminUsers;
        }
        public decimal GetEmployeesNotAssignedToDepartment() => (Math.Round((decimal)(context.Employees.Where(e => e.DepartmentId == null).Count()/GetTotalRecordsNumber()) * 100 , 2));

        public IEnumerable<Employee> GetTopRecords(int RecordsNumber) => context.Employees.Take(RecordsNumber).ToList();

        public int GetTotalRecordsNumber() => context.Employees.Count();


        public void Update(Employee entity)
        {
            context.Update(entity);
            context.SaveChanges();
            Tracker.AddSnapshot(TrackerState.Modify, entity);
        }
    }
}
