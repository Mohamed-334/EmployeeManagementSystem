﻿using EmployeeManagementDatabase.Entities;
using EmployeeManagementSystemWebSite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Repositories.Interfaces;
using Repository.Interfaces;
using System.Diagnostics;
using System.Security.Claims;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EmployeeManagementSystemWebSite.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Employee> userManager;
        private readonly SignInManager<Employee> signIn;
        private readonly IPositionRepository positionRepo;
        private readonly IDepartmentRepository DeptRepo;

        public AccountController(UserManager<Employee> userManager, SignInManager<Employee> ignIn, IPositionRepository position, IDepartmentRepository deptRepo)
        {
            this.userManager = userManager;
            this.signIn = ignIn;
            this.positionRepo = position;
            DeptRepo = deptRepo;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel VM)
        {
            if (ModelState.IsValid)
            {
                var result = await userManager.FindByNameAsync(VM.Username);
                if (result is not null)
                {
                    bool Found = await userManager.CheckPasswordAsync(result, VM.Password);
                    if (Found)
                    {
                        await signIn.SignInAsync(result,VM.RememberMe);
                        string Role = userManager.GetRolesAsync(result).Result.FirstOrDefault();
                        if (Role == "Admin")
                            return RedirectToAction("GetTopTasks", "AdminDashboard");
                        else if (Role == "Employee")
                            return RedirectToAction("GetTopUserTasks", "UserDashboard"); 
                    }
                    else
                    {
                        ModelState.AddModelError("Password", "Wrong Password");
                    }

                }
                else
                {
                    ModelState.AddModelError("Username", "Account doesn't exist , Please SignUp");
                }
                
            }
            return View(VM);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel VM)
        {
            if(ModelState.IsValid)
            {
                var Employee = new Employee();
                Employee.FirstName = VM.FirstName;
                Employee.LastName = VM.LastName;
                Employee.Email = VM.Email;
                Employee.UserName = VM.Username;
                Employee.PasswordHash = VM.Password;

                if(VM.Picture is not  null)
                {
                    using (BinaryReader br = new BinaryReader(VM.Picture.OpenReadStream()))
                    {
                        Employee.ProfilePhoto = br.ReadBytes((int)VM.Picture.Length);
                    }
                }
                Employee.PhoneNumber = VM.PhoneNumber;
                Employee.Address = VM.Address;
                Employee.DepartmentId = VM.DepartmentId;


                var result =await userManager.CreateAsync(Employee,VM.Password);
                if(result.Succeeded)
                {
                    await userManager.AddToRoleAsync(Employee,VM.Role);
                    return RedirectToAction("GetTopTasks", "AdminDashboard");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("DepartmentId", item.Description);
                    }
                }
            }
            
            return View(VM);
        }

        public async Task<IActionResult> Logout()
        {
            await signIn.SignOutAsync();
            return RedirectToAction("Login" , "Account");
        }
        [HttpGet]
        public IActionResult GetDepartments(string Role)
        {
            var model = new List<Department>();
            if(Role == "Admin")
                 model = DeptRepo.GetAll().Where(d => d.DepartmentName.Contains("Adminstration")).ToList();

            else
                 model = DeptRepo.GetAll().Where(d => !d.DepartmentName.Contains("Adminstration")).ToList();

            return Json(model);
        }

        [HttpGet]
        public IActionResult GetPosition(int DeptId)
        {
            var model = positionRepo.GetByForeignKey(DeptId).ToList();
            return Json(model);
        }
    }
}
