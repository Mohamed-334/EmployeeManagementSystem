using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDB.Validation_Attributes
{
    public class DeadLineCheckerAttribute : ValidationAttribute
    {
        public DeadLineCheckerAttribute()
        {
            ErrorMessage = "DeadLine must be greater than Current Date";
        }
        public override bool IsValid(object value)
        {
            DateTime DeadLine = Convert.ToDateTime(value);
            if (DeadLine > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
