﻿using Microsoft.AspNetCore.Http;

namespace EmployeeManagementSystem.Models.DTO
{
    public class ProfileDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public IFormFile? ProfilePhoto { get; set; }
    }
}
