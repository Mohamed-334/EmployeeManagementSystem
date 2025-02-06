using EmployeeManagementDatabase.Entities;
using EmployeeManagementDatabase.Enums;
using EmployeeManagementDB.Entities;
using EmployeeManagementDB.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementDatabase.Data.Config
{
    public class VacationConfiguration : IEntityTypeConfiguration<Vacation>
    {
        public void Configure(EntityTypeBuilder<Vacation> builder)
        {
            builder.HasKey(x => x.Id);  
            builder.Property(e => e.VacationType)
                .HasConversion(e => e.ToString(), e => (VacationType)Enum.Parse(typeof(VacationType),e));

            builder.Property(e => e.At)
                .HasColumnType("DateTime");

            builder.HasOne(v => v.Employee)
                .WithMany(e => e.Vacations)
                .HasForeignKey(v => v.EmployeeId);

            builder.ToTable("Vacation");
        }
    }
}
