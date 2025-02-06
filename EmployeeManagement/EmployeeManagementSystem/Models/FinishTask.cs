using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class FinishTask
    {
        [Required]
        [RegularExpression("https:\\/\\/github\\.com\\/Mohamed-334\\/[A-Za-z0-9!@#$%^&*()\\-_=+[\\]{}|;:'\",.<>?/]+" , ErrorMessage = "Wrong Link Our github is Mohamed-334 ")]
        public string RepoLink { get; set; }
    }
}
