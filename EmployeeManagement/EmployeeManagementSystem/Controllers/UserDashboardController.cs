using EmployeeManagementDatabase.Entities;
using EmployeeManagementDatabase.Enums;
using EmployeeManagementDB.Entities;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using Repository;
using Repository.Interfaces;
using System.Security.Claims;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace EmployeeManagementSystem.Controllers
{
    public class UserDashboardController : Controller
    {
        private readonly IJobRepository JobRepo;
        private readonly IReportRepository ReportRepo;
        private readonly IEmployeeRepository EmpRepo;
        private readonly INotificationRepository NotifyRepo;
        private readonly INotificationSeenRepository UserNotificationRepo;
        private readonly IMailSeenRepository MailSeenRepo;
        private readonly UserManager<Employee> userManager;

        public UserDashboardController(IJobRepository jobRepo, IReportRepository reportRepo, IEmployeeRepository empRepo, INotificationRepository notifyRepo, INotificationSeenRepository userNotificationRepo, UserManager<Employee> userManager, IMailSeenRepository mailSeenRepo)
        {
            JobRepo = jobRepo;
            EmpRepo = empRepo;
            ReportRepo = reportRepo;
            NotifyRepo = notifyRepo;
            UserNotificationRepo = userNotificationRepo;
            this.userManager = userManager;
            MailSeenRepo = mailSeenRepo;
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
            Model.State = TaskState.Accepted;
            JobRepo.Update(Model);
            return PartialView("_CompleteButtonPartial");
        }

        [HttpGet]
        public IActionResult GetMails()
        {
            var UserId = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var Mails = MailSeenRepo.GetUserMails(UserId);
            return PartialView("GetMails", Mails);
        }
        [HttpGet]
        public IActionResult GetMailInfo(int MailId)
        {
            var UserId = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var MailSeen = MailSeenRepo.GetByMailId(MailId,UserId);
            MailSeen.Seen = true;
            MailSeenRepo.Update(MailSeen);
            var Mails = ReportRepo.GetById(MailId);
           
            return PartialView("GetMailInfo", Mails);
        }
        [HttpGet]
        public IActionResult GetTaskInfo(int TaskId)
        {
            var Task = JobRepo.GetById(TaskId);

            return PartialView("_TaskInfoPartial", Task);
        }
        [HttpGet]
        public IActionResult Profile()
        {
            var UserId = User.Claims.First(u => u.Type == ClaimTypes.NameIdentifier).Value;
            Employee emp = EmpRepo.GetById(UserId);
            ProfileDTO profile = new();
            profile.Address = emp.Address;
            profile.Email = emp.Email;
            profile.FirstName = emp.FirstName;
            profile.LastName = emp.LastName;
            profile.PhoneNumber = emp.PhoneNumber;
            profile.UserName = emp.UserName;
            return View(profile);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile(ProfileDTO profile, string Id)
        {
            if (ModelState.IsValid)
            {
                var emp = userManager.FindByIdAsync(Id).Result;
                Notification notify = new();
                notify.NotificationMessage = $"User {emp.FullName} Update His Profile \n";
                if (profile.ProfilePhoto is not null)
                {
                    using (BinaryReader br = new BinaryReader(profile.ProfilePhoto.OpenReadStream()))
                    {
                        byte[] newImage;
                        newImage = br.ReadBytes((int)profile.ProfilePhoto.Length);
                        if (emp.Address == profile.Address && emp.FirstName == profile.FirstName &&
                            emp.LastName == profile.LastName && emp.UserName == profile.UserName &&
                            emp.Email == profile.Email && emp.PhoneNumber == profile.PhoneNumber &&
                            newImage == emp.ProfilePhoto)
                        {
                            return RedirectToAction("Profile");
                        }
                        if (emp.ProfilePhoto != newImage)
                        {

                            notify.NotificationMessage += $"Change The Picture \n";
                            emp.ProfilePhoto = newImage;
                        }


                    }
                }
                if (emp.FirstName != profile.FirstName)
                    notify.NotificationMessage += $"Change The First Name from {emp.FirstName} to {profile.FirstName}\n";
                if (emp.LastName != profile.LastName)
                    notify.NotificationMessage += $"Change The Last Name from {emp.LastName} to {profile.LastName}\n";
                if (emp.UserName != profile.UserName)
                    notify.NotificationMessage += $"Change The UserName from {emp.UserName} to {profile.UserName}\n";
                if (emp.PhoneNumber != profile.PhoneNumber)
                    notify.NotificationMessage += $"Change The Phone Number from {emp.PhoneNumber} to {profile.PhoneNumber}\n";
                if (emp.Address != profile.Address)
                    notify.NotificationMessage += $"Change The Address from {emp.Address} to {profile.Address}\n";
                if (emp.Email != profile.Email)
                    notify.NotificationMessage += $"Change The Email from {emp.Email} to {profile.Email}\n";
                emp.Email = profile.Email;
                emp.Address = profile.Address;
                emp.FirstName = profile.FirstName;
                emp.LastName = profile.LastName;
                emp.PhoneNumber = profile.PhoneNumber;
                emp.UserName = profile.UserName;
                var Result = await userManager.UpdateAsync(emp);
                if(Result.Succeeded)
                {
                    NotifyRepo.Add(notify);

                    if (!User.IsInRole("Admin"))
                    {
                        var UserNotification = new NotificationSeen()
                        {
                            EmployeeId = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value,
                            NotificationId = notify.NotificationId,
                            Seen = false,
                        };
                        UserNotificationRepo.Add(UserNotification);
                    }
                    var admins =  EmpRepo.GetAdmins();
                    foreach (var item in admins)
                    {
                        UserNotificationRepo.Add(new NotificationSeen
                        {
                            EmployeeId = item.Id,
                            NotificationId = notify.NotificationId,
                            Seen = false,
                        });
                    }
                
                    if (User.IsInRole("Employee"))
                        return RedirectToAction("GetTopUserTasks", "UserDashboard");
                    else if (User.IsInRole("Admin"))
                        return RedirectToAction("GetTopTasks", "AdminDashboard");
                    else if (User.IsInRole("Manager"))
                        return RedirectToAction("GetTopTasks", "ManagerDashboard");
                }
                else
                {
                    foreach (var item in Result.Errors)
                    {

                        ModelState.AddModelError("Address",item.Description);
                    }
                }
            }

            return View("Profile", profile);
        }
        public IActionResult TaskTesting(FinishTask FinishTask, int TaskId)
        {
            Report Report = new();
            var UserId = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var emp = EmpRepo.GetById(UserId);
            Job job = JobRepo.GetById(TaskId);
            if (job.State == TaskState.Running)
                job.State = TaskState.Checking;
            job.TaskLink = FinishTask.RepoLink;
            Report.FromEmployeeId = UserId;
            Report.ToEmployeeId = emp.ManagerId;
            Report.ReportType = ReportType.DeliverTask;
            Report.ReportHeader = "Testing Task";
            Report.ReportBody = $"Employee {emp.FullName}" +
                $"\nwant to deliver the Task" +
                $"\nPlease Check it " +
                $"\n\n Task Name : {job.TaskName}";
            Report.TaskId = TaskId;
            JobRepo.Update(job);
            ReportRepo.Add(Report);
            if (!User.IsInRole("Admin"))
            {
                MailSeenRepo.Add(new MailSeen()
                {
                    MailId = Report.Id,
                    EmployeeId = Report.ToEmployeeId,
                    Seen = false
                });
            }
            foreach (var item in EmpRepo.GetAdmins())
            {
                MailSeenRepo.Add(new MailSeen() { 
                    MailId = Report.Id,
                    EmployeeId = item.Id, 
                    Seen = false 
                });
            }
            Notification notification = new();
            notification.NotificationMessage = $"Task With Name {job.TaskName} Starting the Deliver Process";
            NotifyRepo.Add(notification);
            if (!User.IsInRole("Admin"))
            {
                var UserNotification = new NotificationSeen()
                {
                    EmployeeId = UserId,
                    NotificationId = notification.NotificationId,
                    Seen = false,
                };
                UserNotificationRepo.Add(UserNotification);
                if(emp.ManagerId is not null)
                {
                    var ManagerNotification = new NotificationSeen()
                    {
                        EmployeeId = emp.ManagerId,
                        NotificationId = notification.NotificationId,
                        Seen = false,
                    };
                    UserNotificationRepo.Add(ManagerNotification);
                }
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
            return RedirectToAction("GetTopUserTasks", "UserDashboard");
        }
        [HttpGet]
        public IActionResult Notifications()
        {
            IEnumerable<Notification> notifications;
            string UserId = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
            notifications = UserNotificationRepo.GetUserUnseenNotifications(UserId);
            return View(notifications);
        }
        [HttpPost]
        public IActionResult EditNotification(int NotificationId)
        {
            string UserId = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
            var UserNotification = UserNotificationRepo.GetByNotification(NotificationId,UserId);
            UserNotification.Seen = true;
            UserNotificationRepo.Update(UserNotification);
            return PartialView("_NotificationIconPartial");
        }

    }
}



