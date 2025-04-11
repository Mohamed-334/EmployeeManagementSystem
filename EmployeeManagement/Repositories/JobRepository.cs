using EmployeeManagementDatabase.Data;
using EmployeeManagementDatabase.Entities;
using EmployeeManagementDatabase.Enums;
using Repositories.Factory;
using Repository.Interfaces;
using System.Linq;
using System.Linq.Expressions;

namespace Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDbContext context = AppDbContextFactory.Create();

        public IEnumerable<Job> GetAll() => context.Jobs.ToList();

        public Job GetById(int id) => context.Jobs.Find(id);

        public void Delete(Job entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }

        public void Update(Job entity)
        {
           context.Update(entity);
            context.SaveChanges();
        }

        public void Dispose() => context.Dispose();

        public IEnumerable<Job> GetByForeignKey(Func<Job, bool> filter) => context.Jobs.Where(filter).ToList();

        public IEnumerable<Job> GetTopRecords(int RecordsNumber) => context.Jobs.Take(RecordsNumber).OrderBy(e => e.Employee.FirstName).ToList();

        public decimal GetCompletedTaskPercentage(string UserId , string Role)
        {
            decimal Records = 0;
            switch (Role)
            {
                case "Admin":
                    Records = context.Jobs.Count();
                    break;
                case "Employee":
                    Records = context.Jobs.Where(u => u.EmployeeId == UserId).Count();
                    break;
                case "Manager":
                    var Manager = context.Employees.First(e => e.Id == UserId);
                    var emps = Manager.EmployeesOfManager;
                    Records = emps.SelectMany(e => e.Tasks).Count(u => u.State == TaskState.Accepted);
                    break;
            }

                decimal CompletedRecords = context.Jobs.Where(j => j.State == TaskState.Accepted).Count();
            return Math.Round((CompletedRecords / Records)*100);
        }

        public int GetTotalCompletedTasks() => context.Jobs.Where(j => j.State == TaskState.Accepted).Count();

        public int GetTotalRecordsNumber() => context.Jobs.Count();

        public void Add(Job entity)
        {
            context.Jobs.Add(entity);
            context.SaveChanges();
        }

        public IEnumerable<Job> GetTopRecordsByForeignKey(int Records , Func<Job,bool> condition) => context.Jobs
            .Where(condition).Take(Records).ToList();


        ~JobRepository()
        {
            GC.SuppressFinalize(this);
        }
    }
}