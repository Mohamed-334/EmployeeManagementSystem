using EmployeeManagementDatabase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;

namespace EmployeeManagementDatabase.Data.Config
{
    public class EmployeeAttendanceConfiguration : IEntityTypeConfiguration<EmployeeAttendance>
    {
        public void Configure(EntityTypeBuilder<EmployeeAttendance> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.StartTime)
               .HasColumnType("Time")
                .IsRequired();

            builder.HasKey(x => x.Id);
            builder.Property(x => x.EndTime)
               .HasColumnType("Time")
                .IsRequired();

            builder.Property(x => x.Date)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(x => x.Day)
                .HasColumnType("varchar")
                .HasMaxLength(10)
                .IsRequired();

            builder.HasOne(a => a.Employee)
                .WithMany(e => e.Attendances)
                .HasForeignKey(e => e.EmployeeId)
                 .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            builder.ToTable("Attendance");
        }
    }

}
