using EmployeeManagementDatabase.Entities;
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
            return RedirectToAction("GetTopUserTasks", "UserDashboard");
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
            else
                return RedirectToAction("GetTopTasks", "AdminDashboard");
        }
        [HttpGet]
        public IActionResult EndWork()
        {
            EmpAtt.EndTime = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            EmpAtt.IsEnded = true;
            return RedirectToAction("TakeAttendance", "Request", EmpAtt);
        }
    }
}
