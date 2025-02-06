using EmployeeManagementDatabase.Enums;
using EmployeeManagementDB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDatabase.Entities
{
    public class Report
    {
        public int Id { get; set; }
        public string? FromEmployeeId { get; set; }
        public string? ToEmployeeId { get; set; }
        public int? TaskId { get; set; }
        public string ReportHeader { get; set; }
        public string ReportBody { get; set; }
        public ReportType ReportType { get; set; }
        public DateTime SendAt { get; set; } = DateTime.Now;


        public virtual Employee? FromEmployee { get; set; }
        public virtual Employee? ToEmployee { get; set; }
        public virtual ICollection<MailSeen> MailSeen { get; set; }
        public virtual Job? Job { get; set; }
    }
}
