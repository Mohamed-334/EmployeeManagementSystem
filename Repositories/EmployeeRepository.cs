﻿using EmployeeManagementDatabase.Data;
using EmployeeManagementDatabase.Entities;
using Microsoft.AspNetCore.Identity;
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
        private readonly AppDbContext context = new();

        public void Add(Employee entity)
        {
            context.Employees.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Employee entity)
        {
            context.Remove(entity);
            context.SaveChanges();
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

        public Employee GetById(string id) => context.Employees.Find(id);

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
        }
    }
}