using EmployeeManagementDatabase.Data;
using EmployeeManagementDatabase.Entities;
using Repositories.Factory;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ReportRepository : IReportRepository
    {
        private readonly AppDbContext context = AppDbContextFactory.Create();
        public void Delete(Report entity)
        {
            context.Remove(entity);
            context.SaveChanges();
        }

        public IEnumerable<Report> GetAll() => context.Reports.ToList();

        public IEnumerable<Report> GetByForeignKey(Func<Report , bool> filter) => context.Reports.Where(filter).ToList();

        public Report GetById(int id) => context.Reports.Find(id);

        public void Update(Report entity)
        {
            context.Update(entity);
            context.SaveChanges();
        }
        public void Dispose() => context.Dispose();

        public void Add(Report entity)
        {
            context.Reports.Add(entity);
            context.SaveChanges();
        }

        public int NumberOfReportsLastYear() => context.Reports is null?0 :context.Reports.Where(r => r.SendAt.Year == DateOnly.FromDateTime(DateTime.Now).Month - 1).Count();

        public int GetTotalRecordsNumber() => context.Reports is null ? 0 :context.Reports.Count();

        public int NumberOfReportsLastMonth() => context.Reports is null ? 0 : context.Reports.AsEnumerable().Where(r => r.SendAt.Month == DateOnly.FromDateTime(DateTime.Now).Month - 1).Count();

        public int NumberOfOwnReports(string id) => context.Reports is null ? 0 : context.Reports.Where(r => r.ToEmployeeId == id).Count();

        public decimal PercentageOfReportsGenerated(string id) => this.GetTotalRecordsNumber() == 0? 0: Math.Round((decimal)(this.NumberOfOwnReports(id) / this.GetTotalRecordsNumber()) * 100 , 2);

        ~ReportRepository()
        {
            GC.SuppressFinalize(this);
        }
    }
}
