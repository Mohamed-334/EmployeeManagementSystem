using EmployeeManagementDatabase.Entities;
using EmployeeManagementSystemWebSite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repository.Interfaces;
using System.Security.Claims;
using System.Web;

namespace EmployeeManagementSystemWebSite.Controllers
{
    public class AdminDashboardController : Controller
    {
        private readonly IReportRepository ReportRepo;
        private readonly IJobRepository TaskRepo;
        private readonly IEmployeeRepository EmpRepo;

        public AdminDashboardController(IReportRepository reportRepo, IJobRepository taskRepo, IEmployeeRepository empRepo)
        {
            ReportRepo = reportRepo;
            TaskRepo = taskRepo;
            EmpRepo = empRepo;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult GetTopTasks()
        {
            return View("AdminDashboardMain" , new Job());
        }
        public IActionResult GetAllTasks()
        {
            return View("AllTasks", new Job());
        }
        public IActionResult GetTopReports()
        {
            return View("Reports" );
        }

        public IActionResult GetAllReports()
        {
            return View("AllReports");
        }

        [HttpGet]
        public IActionResult AddReport()
        {
            return View("AddReport");
        }
        [HttpPost]
        public IActionResult AddReport(Report report, string UserName)
        {
            if (ModelState.IsValid)
            {
                ReportRepo.Add(report);
                return RedirectToAction("GetTopReports");
            }
            return View("AddReport", report);
        }
        [HttpGet]
        public IActionResult ShowReportInfo(int Id)
        {
            var model = ReportRepo.GetById(Id);
            return PartialView("ShowReportInfo" , model);
        }
        public IActionResult GetTopEmployees()
        {
            return View("Employees", new Employee());
        }
        public IActionResult GetAllEmployees()
        {
            return View("AllEmployees", new Employee());
        }

        [HttpPost]
        public IActionResult AddTask(Job job)
        {
            job.DeadLine = DateOnly.Parse(Request.Form["deadline"]);
            if(ModelState.IsValid)
            {
                TaskRepo.Add(job);
                return RedirectToAction("GetTopTasks");
            }
            return View("AdminDashboardMain", job);
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return View("Contacts");
        }
        [HttpGet]
        public IActionResult GetAllContacts()
        {
            return View("GetAllContacts");
        }
        [HttpPost]
        public IActionResult AddAccount(RegisterViewModel VM)
        {
            return View("GetAllContacts");
        }
        public IActionResult GetImage(string id)
        {
            var Emp = EmpRepo.GetById(id);
            if (Emp.ProfilePhoto != null)
            {
                return File(Emp.ProfilePhoto, "image/png");
            }
            else
            {
                 return NotFound();  
            }
        }
    }
}
