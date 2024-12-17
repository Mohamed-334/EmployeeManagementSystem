using EmployeeManagementDatabase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementDatabase.Data.Config
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.DepartmentName).
                    IsRequired().
                    HasColumnType("Varchar").
                    HasMaxLength(100).
                    IsRequired();

            builder.HasMany(e => e.Employees)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            
             builder.HasData(LoadData());
            builder.ToTable("Departments");
        }
        public List<Department> LoadData()
        {
            return new List<Department>
            {
                new Department
                {
                    Id = 2,
                    DepartmentName = "Back-end",
                    EmployeeId = "1",

                },

                new Department
                {
                    Id = 4,
                    DepartmentName = "Front-end",
                    EmployeeId = "4",

                },

                 new Department
                {
                    Id = 6,
                    DepartmentName = "Adminstration",
                    EmployeeId = "7"
                },
            };
        }
    }

}
