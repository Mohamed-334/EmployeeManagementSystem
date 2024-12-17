using EmployeeManagementDatabase.Entities;
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

            builder.Property(r => r.ReportBody).
               HasColumnName("Body").
               HasColumnType("Varchar").
               HasMaxLength(255).
               IsRequired();

            builder.Property(r => r.SendAt).
              HasColumnType("Date").
              IsRequired();

            builder.HasOne<Employee>(r => r.Employee)
                .WithMany(e => e.Reports)
                .HasForeignKey(e =>e.EmployeeId)
                 .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            builder.HasData(LoadData());
            builder.ToTable("Reports");
        }

        private List<Report> LoadData()
        {
            return new List<Report>
            {
                new Report()
                {
                    Id = 1,
                    EmployeeId = "3",
                    ReportHeader = "Login Page",
                    ReportBody = "Login Page has Been Completed",
                    SendAt =  new DateOnly(2024,12,3)
                },
                new Report()
                {
                    Id = 2,
                    EmployeeId = "3",
                    ReportHeader = "Back-end Login Page",
                    ReportBody = " Back-end Login Page has Been Completed",
                    SendAt =  new DateOnly(2024,12,5)
                },
            };
        }


    }

}
