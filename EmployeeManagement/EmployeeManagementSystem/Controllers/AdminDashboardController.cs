using EmployeeManagementDatabase.Entities;
using EmployeeManagementDB.Entities;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystemWebSite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
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
        private readonly IDepartmentRepository DeptRepo;
        private readonly INotificationRepository NotificationRepo;
        private readonly INotificationSeenRepository UserNotificationRepo;
        private readonly IMailSeenRepository MailSeenRepo;
        private readonly IPositionRepository PositionRepo;


        public AdminDashboardController(IReportRepository reportRepo, IJobRepository taskRepo, IEmployeeRepository empRepo, IDepartmentRepository deptRepo, IPositionRepository positionRepo, INotificationRepository notificationRepo, INotificationSeenRepository userNotificationRepo, IMailSeenRepository mailSeenRepo)
        {
            ReportRepo = reportRepo;
            TaskRepo = taskRepo;
            EmpRepo = empRepo;
            DeptRepo = deptRepo;
            PositionRepo = positionRepo;
            NotificationRepo = notificationRepo;
            UserNotificationRepo = userNotificationRepo;
            MailSeenRepo = mailSeenRepo;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult GetTopTasks()
        {
            return View("AdminDashboardMain" , new Job());
        }
        public IActionResult GetAllTasks()
        {
            return View("AllTasks" , new Job());
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
        [ValidateAntiForgeryToken]
        public IActionResult AddReport(Report report, string UserName)
        {
            report.FromEmployeeId = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
            if (ModelState.IsValid)
            {
                ReportRepo.Add(report);
                if (!User.IsInRole("Admin"))
                {
                    MailSeenRepo.Add(new MailSeen()
                    {
                        EmployeeId = report.ToEmployeeId,
                        MailId = report.Id,
                        Seen = false
                    });
                }
                foreach (var item in EmpRepo.GetAdmins())
                {
                    MailSeenRepo.Add(new MailSeen()
                    {
                        EmployeeId = item.Id,
                        MailId = report.Id,
                        Seen = false
                    });
                }
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
        [ValidateAntiForgeryToken]
        public IActionResult AddAccount(RegisterViewModel VM)
        {
            return View("GetAllContacts");
        }
        [HttpGet]
        public IActionResult AddDepartment()
        {
            return View("AddDepartment");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddDepartment(DepartmentViewModel VM)
        {
            Department dept = new();
            if (ModelState.IsValid)
            {
                try
                {
                    dept.DepartmentName = VM.DepartmentName;
                    DeptRepo.Add(dept);
                }
                catch(Exception ex)
                {
                    ModelState.AddModelError("DepartmentName", ex.Message);
                }
                finally
                {
                    Notification notification = new();
                    notification.NotificationMessage = $"Department with Name ({VM.DepartmentName}) has been Added";
                    NotificationRepo.Add(notification);
                    foreach (var admin in EmpRepo.GetAdmins())
                    {
                        UserNotificationRepo.Add(new NotificationSeen { NotificationId = notification.NotificationId, EmployeeId = admin.Id });
                    }
                }
                dept.DepartmentName = VM.DepartmentName;
                DeptRepo.Add(dept);
                return RedirectToAction("GetTopTasks", "AdminDashboard");
            }
            return View("AddDepartment", dept);
        }

        [HttpGet]
        public IActionResult AddPosition()
        {
            return View("AddPosition");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddPosition(PositionViewModel VM)
        {
            Position position = new();
            if (ModelState.IsValid)
            {
                try
                {
                    position.PositionName = VM.PositionName;
                    position.DepartmentId = VM.DepartmentId;
                    PositionRepo.Add(position);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("DepartmentId", ex.Message);
                }
                finally
                {
                    Notification notification = new();
                    Department dept = DeptRepo.GetById(VM.DepartmentId);
                    notification.NotificationMessage = $"Position with Name ({VM.PositionName}) has been Added by {dept.DepartmentName} Department";
                    NotificationRepo.Add(notification);
                    foreach (var admin in EmpRepo.GetAdmins())
                    {
                        UserNotificationRepo.Add(new NotificationSeen { NotificationId = notification.NotificationId, EmployeeId = admin.Id });
                    }
                }
                return RedirectToAction("GetTopTasks", "AdminDashboard");
            }
            return View("AddPosition",position);
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
