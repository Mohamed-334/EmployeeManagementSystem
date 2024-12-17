using EmployeeManagementDatabase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementDatabase.Data.Config
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(t => t.Id)
                .UseIdentityColumn();

            builder.Property(t => t.TaskName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(t => t.TaskDescription)
                .HasColumnType("varchar")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(t => t.DeadLine)
                .HasColumnType("Date")
                .IsRequired();

            builder.HasOne(t => t.Employee)
                .WithMany(e => e.Tasks)
                .HasForeignKey(t => t.EmployeeId)
                 .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            builder.HasData(LoadData());
            builder.ToTable("Jobs");
        }

        private List< Job> LoadData()
        {
            return new List<Job> {

                new Job
                {
                    Id = 6,
                    TaskName = "LoginPage",
                    TaskDescription = "Create Login Page For the Employee System",
                    DeadLine = new DateOnly(2025 ,05 ,12),
                    Done = false,
                    EmployeeId = "4"
                },

                new Job
                {
                    Id = 7,
                    TaskName = "Photo Package Page",
                    TaskDescription = "Create Page that Hold Related Cars Photos",
                    DeadLine = new DateOnly(2025 ,09 ,1),
                    Done = false,
                    EmployeeId = "5"
                },
                new Job
                {
                    Id = 8,
                    TaskName = "Register Page",
                    TaskDescription = "Create Register Page For the Employee System",
                    DeadLine = new DateOnly(2024 ,12 ,10),
                    Done = false,
                    EmployeeId = "4"
                },
                new Job
                {
                    Id = 9,
                    TaskName = " Back-end Login Page",
                    TaskDescription = "Create back-end Login Page For the Employee System",
                    DeadLine = new DateOnly(2025 ,2 ,2),
                    Done = false,
                    EmployeeId = "2"
                },
                new Job
                {
                    Id = 10,
                    TaskName = "Back-end Register Page",
                    TaskDescription = "Create Back-end Register Page For the Employee System",
                    DeadLine = new DateOnly(2025 ,2 ,1),
                    Done = false,
                    EmployeeId = "1"
                },
            };
        }
    }
}
