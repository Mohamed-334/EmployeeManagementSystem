using EmployeeManagementDatabase.Data;
using EmployeeManagementDatabase.Entities;
using Repository.Interfaces;

namespace Repository
{
    public class JobRepository : IJobRepository
    {
        private readonly AppDbContext context = new();

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

        public IEnumerable<Job> GetByForeignKey(string ForeinKey) => context.Jobs.Where(e => e.EmployeeId == ForeinKey).ToList();

        public IEnumerable<Job> GetTopRecords(int RecordsNumber) => context.Jobs.Take(RecordsNumber).ToList();

        public decimal GetCompletedTaskPercentage()
        {
            decimal Records = context.Jobs.Count();
            decimal CompletedRecords = context.Jobs.Where( j => j.Done).Count();
            return Math.Round((CompletedRecords / Records)*100);
        }

        public int GetTotalCompletedTasks() => context.Jobs.Where(j => j.Done).Count();

        public int GetTotalRecordsNumber() => context.Jobs.Count();

        public void Add(Job entity)
        {
            context.Jobs.Add(entity);
            context.SaveChanges();
        }

        ~JobRepository()
        {
            GC.SuppressFinalize(this);
        }
    }
}