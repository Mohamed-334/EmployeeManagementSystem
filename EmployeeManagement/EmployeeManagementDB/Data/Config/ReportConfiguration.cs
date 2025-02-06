using EmployeeManagementDatabase.Entities;
using EmployeeManagementDatabase.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementDatabase.Data.Config
{
    public class ReportConfiguration : IEntityTypeConfiguration<Report>
    {
        public void Configure(EntityTypeBuilder<Report> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.ReportHeader).
                HasColumnName("Header").
                HasColumnType("Varchar").
                HasMaxLength(30).
                IsRequired();

            builder.Property(e => e.ReportType)
                .HasConversion(e => e.ToString(), e => (ReportType)Enum.Parse(typeof(ReportType), e));


            builder.Property(r => r.ReportBody).
               HasColumnName("Body").
               HasColumnType("Varchar(Max)").
               IsRequired();

            builder.Property(r => r.SendAt).
              HasColumnType("DateTime").
              IsRequired();

            builder.HasOne<Employee>(r => r.FromEmployee)
                .WithMany(e => e.FromReports)
                .HasForeignKey(e =>e.FromEmployeeId)
                 .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder.HasOne<Employee>(r => r.ToEmployee)
                .WithMany(e => e.ToReports)
                .HasForeignKey(e => e.ToEmployeeId)
                 .OnDelete(DeleteBehavior.Restrict)
                .IsRequired(false);

            builder.HasData(LoadData());
            builder.ToTable("Report");
        }

        private List<Report> LoadData()
        {
            return new List<Report>
            {
                new Report()
                {
                    Id = 1,
                    ToEmployeeId = "3",
                    FromEmployeeId = "7",
                    ReportHeader = "Login Page",
                    ReportBody = "Login Page has Been Completed",
                    ReportType = ReportType.DeliverTask,
                    SendAt =  new DateTime(2024,12,3)
                },
                new Report()
                {
                    Id = 2,
                    ToEmployeeId = "3",
                    FromEmployeeId = "7",
                    ReportHeader = "Back-end Login Page",
                    ReportBody = " Back-end Login Page has Been Completed",
                    ReportType = ReportType.DeliverTask,
                    SendAt =  new DateTime(2024,12,5)
                },
            };
        }


    }

}
