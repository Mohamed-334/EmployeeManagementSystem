using EmployeeManagementDatabase.Entities;
using EmployeeManagementDatabase.Enums;
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
                .HasConversion(e => e.ToString(), e => (Vacations)Enum.Parse(typeof(Vacations),e));

            builder.Property(e => e.At)
                .HasColumnType("Date");

            builder.HasOne(v => v.Employee)
                .WithMany(e => e.Vacations)
                .HasForeignKey(v => v.EmployeeId);

            builder.ToTable("Vacations");
        }
    }
}
