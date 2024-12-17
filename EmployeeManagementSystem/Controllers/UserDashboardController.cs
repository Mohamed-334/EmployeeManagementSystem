using EmployeeManagementDatabase.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using Repository;
using Repository.Interfaces;
using System.Security.Claims;

namespace EmployeeManagementSystem.Controllers
{
    public class UserDashboardController : Controller
    {
        private readonly IJobRepository JobRepo;
        private readonly IReportRepository ReportRepo;

        public UserDashboardController(IJobRepository jobRepo, IReportRepository reportRepo)
        {
            JobRepo = jobRepo;
            ReportRepo = reportRepo;
        }

        [Authorize(Roles = "Employee")]
        public IActionResult GetTopUserTasks()
        {
            return View("GetTopUserTasks");
        }
        public IActionResult GetAllUserTasks()
        {
            return View();
        }

        public IActionResult SetTaskDone(int id)
        {
            var Model = JobRepo.GetById(id);
            Model.Done = true;
            JobRepo.Update(Model);
            return PartialView("_CompleteButtonPartial");
        }

        [HttpGet]
        public IActionResult GetMails()
        {
            var Mails = ReportRepo.GetByForeignKey(User.Claims.FirstOrDefault(e => e.Type == ClaimTypes.NameIdentifier).Value);
            return PartialView("GetMails", Mails);
        }
        [HttpGet]
        public IActionResult GetMailInfo(int MailId)
        {
            var Mails = ReportRepo.GetById(MailId);
            return PartialView("GetMailInfo", Mails);
        }

    }
}
