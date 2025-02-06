using EmployeeManagementDatabase.Entities;
using EmployeeManagementDatabase.Enums;
using EmployeeManagementDB.Entities;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using Repository.Interfaces;
using System.Security.Claims;

namespace EmployeeManagementSystem.Controllers
{
    public class ManagerDashboardController : Controller
    {
        private readonly IJobRepository TaskRepo;
        private readonly IEmployeeRepository EmpRepo;
        private readonly IReportRepository ReportRepo;
        private readonly INotificationRepository NotifyRepo;
        private readonly INotificationSeenRepository UserNotificationRepo;
        private readonly IMailSeenRepository MailSeenRepo;

        public ManagerDashboardController(IJobRepository TaskRepo, IEmployeeRepository empRepo, IReportRepository reportRepo, INotificationRepository notifyRepo, INotificationSeenRepository userNotificationRepo, IMailSeenRepository mailRepo)
        {
            this.TaskRepo = TaskRepo;
            EmpRepo = empRepo;
            ReportRepo = reportRepo;
            NotifyRepo = notifyRepo;
            UserNotificationRepo = userNotificationRepo;
            MailSeenRepo = mailRepo;
        }
        public IActionResult GetTopTasks()
        {
            return View();
        }
        public IActionResult GetAllTasks()
        {
            return View();
        }
        public IActionResult GetTopEmployees()
        {
            return View();
        }
        public IActionResult GetAllEmployees()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddTask(Job job)
        {
            if (ModelState.IsValid)
            {
                var ManagerId = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
                var Manager = EmpRepo.GetById(ManagerId);
                var emp = EmpRepo.GetById(job.EmployeeId);
                TaskRepo.Add(job);
                Notification notification = new();
                notification.NotificationMessage = $"Task With Name {job.TaskName} Has been  Added by {Manager.FullName} to {emp.FullName}";
                NotifyRepo.Add(notification);
                if (!User.IsInRole("Admin"))
                {
                    var UserNotification = new NotificationSeen()
                    {
                        EmployeeId = ManagerId,
                        NotificationId = notification.NotificationId,
                        Seen = false,
                    };
                    UserNotificationRepo.Add(UserNotification);
                    var TaskUserNotification = new NotificationSeen()
                    {
                        EmployeeId = job.EmployeeId,
                        NotificationId = notification.NotificationId,
                        Seen = false,
                    };
                    UserNotificationRepo.Add(TaskUserNotification);
                }
                var admins = EmpRepo.GetAdmins();
                foreach (var item in admins)
                {
                    UserNotificationRepo.Add(new NotificationSeen
                    {
                        EmployeeId = item.Id,
                        NotificationId = notification.NotificationId,
                        Seen = false,
                    });
                }

                return RedirectToAction("GetTopTasks");
            }
            return View("GetTopTasks", job);
        }
        public IActionResult Contacts()
        {
            return View();
        }
        public IActionResult GetAllContacts()
        {
            return View();
        }

        [Route("ManagerDashboard/AcceptedTask/{TaskId}/{MailId}")]
        public IActionResult AcceptedTask(int TaskId,int MailId )
        {
            var ManagerId = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var Manager = EmpRepo.GetById(ManagerId);
            var Task = TaskRepo.GetById(TaskId);
            Task.State = TaskState.Accepted;
            TaskRepo.Update(Task);
            Notification notification = new();
            notification.NotificationMessage = $"Task With Name {Task.TaskName} Has been  Accepted by {Manager.FullName}";
            NotifyRepo.Add(notification);
            if (!User.IsInRole("Admin"))
            {
                var UserNotification = new NotificationSeen()
                {
                    EmployeeId = ManagerId,
                    NotificationId = notification.NotificationId,
                    Seen = false,
                };
                UserNotificationRepo.Add(UserNotification);
                var TaskUserNotification = new NotificationSeen()
                {
                    EmployeeId = Task.EmployeeId,
                    NotificationId = notification.NotificationId,
                    Seen = false,
                };
                UserNotificationRepo.Add(TaskUserNotification);
            }
            var admins = EmpRepo.GetAdmins();
            foreach (var item in admins)
            {
                UserNotificationRepo.Add(new NotificationSeen
                {
                    EmployeeId = item.Id,
                    NotificationId = notification.NotificationId,
                    Seen = false,
                });
            }
            return RedirectToAction("GetMailInfo" , "UserDashboard", new { MailId = MailId });
        }
        [Route("ManagerDashboard/RejectedTask/{TaskId}/{EmpId}/{MailId}")]
        public IActionResult RejectedTask(int TaskId , string EmpId, int MailId, string RejectionReasons)
        {
            var ManagerId = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var Manager= EmpRepo.GetById(ManagerId);
            var Task = TaskRepo.GetById(TaskId);
            Task.State = TaskState.Rejected;
            TaskRepo.Update(Task);
             
            var Report = new Report()
            {
                FromEmployeeId = User.Claims.First(e => e.Type == ClaimTypes.NameIdentifier).Value,
                ToEmployeeId = EmpId,
                ReportHeader = "Task has been Rejected",
                ReportType = ReportType.RejectTask,
                ReportBody = $"Task With Name {Task.TaskName} has been Rejected\n" +
                             $"Reasons : {RejectionReasons} "
            };
            ReportRepo.Add(Report);
            MailSeenRepo.Add(new MailSeen()
            {

                EmployeeId = Report.ToEmployeeId,
                MailId = Report.Id,
                Seen = false
            });
            foreach (var item in EmpRepo.GetAdmins())
            {
                MailSeenRepo.Add(new MailSeen()
                {
                    MailId = Report.Id,
                    EmployeeId = item.Id,
                    Seen = false
                });
            }
            Notification notification = new();
            notification.NotificationMessage = $"Task With Name {Task.TaskName} Has been  Rejected by {Manager.FullName}";
            NotifyRepo.Add(notification);
            if (!User.IsInRole("Admin"))
            {
                var UserNotification = new NotificationSeen()
                {
                    EmployeeId = ManagerId,
                    NotificationId = notification.NotificationId,
                    Seen = false,
                };
                UserNotificationRepo.Add(UserNotification);
                var TaskUserNotification = new NotificationSeen()
                {
                    EmployeeId = Task.EmployeeId,
                    NotificationId = notification.NotificationId,
                    Seen = false,
                };
                UserNotificationRepo.Add(TaskUserNotification);
            }
            var admins = EmpRepo.GetAdmins();
            foreach (var item in admins)
            {
                UserNotificationRepo.Add(new NotificationSeen
                {
                    EmployeeId = item.Id,
                    NotificationId = notification.NotificationId,
                    Seen = false,
                });
            }
            return RedirectToAction("GetMailInfo", "UserDashboard", new { MailId = MailId });
        }

    }
}
