using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class DepartmentViewModel
    {
        [Required]
        public string DepartmentName { get; set; }
        public string? DepartmentPresident { get; set; }
    }
}
