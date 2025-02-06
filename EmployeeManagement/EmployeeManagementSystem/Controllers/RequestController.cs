using EmployeeManagementDatabase.Entities;
using EmployeeManagementDB.Entities;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using System.Security.Claims;

namespace EmployeeManagementSystem.Controllers
{
    public class RequestController : Controller
    {
        private readonly IVacationRepository VacationRepo;
        private readonly IAttendanceRepository AttRepo;
        public static EmployeeAttendance EmpAtt = new();

        public RequestController(IVacationRepository vacationRepo, IAttendanceRepository attRepo)
        {
            VacationRepo = vacationRepo;
            AttRepo = attRepo;
        }

        [HttpGet]
        public IActionResult AddVacation()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddVacation(Vacation model)
        {
            if (ModelState.IsValid)
            {
                VacationRepo.Add(model);
                return RedirectToAction("AddVacation", "Request");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult TakeAttendance(EmployeeAttendance attendance)
        {
            AttRepo.Add(attendance);
            if (User.IsInRole("Employee"))
                return RedirectToAction("GetTopUserTasks", "UserDashboard");
            else if (User.IsInRole("Admin"))
                return RedirectToAction("GetTopTasks", "AdminDashboard");
            else if (User.IsInRole("Manager"))
                return RedirectToAction("GetTopTasks", "ManagerDashboard");
            else
                return NotFound();

        }
        [HttpGet]
        public IActionResult DisplayAttendance()
        {

            return View();
        }
        [HttpGet]
        public IActionResult StartWork()
        {
            EmpAtt.StartTime = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            EmpAtt.Day = DateTime.Now.ToString("dddd");
            EmpAtt.Date = DateOnly.FromDateTime(DateTime.Now);
            EmpAtt.EmployeeId = User.Claims.First(e => e.Type == ClaimTypes.NameIdentifier).Value;
            EmpAtt.IsStarted = true;
            if (User.IsInRole("Employee"))
                return RedirectToAction("GetTopUserTasks", "UserDashboard");
            else if (User.IsInRole("Admin"))
                return RedirectToAction("GetTopTasks", "AdminDashboard");
            else
                return RedirectToAction("GetTopTasks", "ManagerDashboard");
        }
        [HttpGet]
        public IActionResult EndWork()
        {
            EmpAtt.EndTime = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            EmpAtt.IsEnded = true;
            EmpAtt.TotalTimeWork = EmpAtt.EndTime - EmpAtt.StartTime;
            if(EmpAtt.TotalTimeWork >= new TimeSpan(8, 0, 0))
                EmpAtt.State = "Attendant";
            else
                EmpAtt.State = "Absent";
            return RedirectToAction("TakeAttendance", "Request", EmpAtt);
        }
    }
}
