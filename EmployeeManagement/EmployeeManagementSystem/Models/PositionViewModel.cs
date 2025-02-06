using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class PositionViewModel
    {
        [Required]
        public string  PositionName{ get; set; }
        [Required]
        public int  DepartmentId{ get; set; }
    }
}
