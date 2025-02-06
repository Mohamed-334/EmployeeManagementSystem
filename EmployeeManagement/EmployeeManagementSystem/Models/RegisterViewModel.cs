using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystemWebSite.Models
{
    public class RegisterViewModel
    {
        [MinLength(3 , ErrorMessage ="Field Must Hold 3 letters At Least")]
        [MaxLength(20, ErrorMessage = "Field Must Hold maximum 20 letters")]
        [Required]
        public string FirstName { get; set; }
        [MinLength(3, ErrorMessage = "Field Must Hold 3 letters At Least")]
        [MaxLength(20, ErrorMessage = "Field Must Hold maximum 20 letters")]
        [Required]
        public string LastName { get; set; }
        [MinLength(3, ErrorMessage = "Field Must Hold 3 letters At Least")]
        [MaxLength(30, ErrorMessage = "Field Must Hold maximum 30 letters")]
        [Required]
        public string Username { get; set; }
        [Required]
        [RegularExpression("^[\\w\\.-]+@[a-zA-Z\\d\\.-]+\\.[a-zA-Z]{2,6}$" , ErrorMessage ="Please Enter Validate Email")]
        public string Email { get; set; }
        [Required]
        public  string Password { get; set; }
        [Required]
        [Compare("Password" , ErrorMessage = "Password Not Matched")]
        public string ConfirmPassword { get; set; }
        public int PositionId { get; set; }
        public int DepartmentId { get; set; }
        public string? ManagerId { get; set; }
        public string Address { get; set; }
        [RegularExpression("^(\\+20|0)?1[0125]\\d{8}$" , ErrorMessage = "Please Enter Validate Number")]
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
        [Required]
        public IFormFile Picture { get; set; }
    }
}
