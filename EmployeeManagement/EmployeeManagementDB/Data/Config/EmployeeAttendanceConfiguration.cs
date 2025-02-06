using EmployeeManagementDB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementDatabase.Data.Config
{
    public class EmployeeAttendanceConfiguration : IEntityTypeConfiguration<EmployeeAttendance>
    {
        public void Configure(EntityTypeBuilder<EmployeeAttendance> builder)
        {
            builder.HasKey(x => x.Id);


            builder.Property(e => e.Date)
                .HasColumnType("Date");

            builder.Property(e => e.StartTime)
                .HasColumnType("time");

            builder.Property(e => e.EndTime)
                .HasColumnType("time");

            builder.HasOne(v => v.Employee)
                .WithMany(e => e.Attendances)
                .HasForeignKey(v => v.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            builder.ToTable("Attendance");
        }
    }
}
