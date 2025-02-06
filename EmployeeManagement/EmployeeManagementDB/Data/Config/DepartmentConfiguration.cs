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

            builder.HasIndex(e => e.DepartmentName).IsUnique();

            builder.HasMany(e => e.Positions)
                .WithOne(e => e.Department)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            builder.HasOne(e => e.President)
                .WithOne(e => e.Department)
                .HasForeignKey<Department>(e => e.DepartmentPresident)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            builder.HasData(LoadData());
            builder.ToTable("Department");
        }
        public static List<Department> LoadData()
        {
            return new List<Department>
            {
                new Department
                {
                    Id = 2,
                    DepartmentName = "Back-end",

                },

                new Department
                {
                    Id = 4,
                    DepartmentName = "Front-end",

                },

                 new Department
                 {
                    Id = 6,
                    DepartmentName = "Adminstration",
                },
                 new Department
                 {
                    Id = 7,
                    DepartmentName = "Tech Management",
                },
                 new Department
                 {
                    Id = 8,
                    DepartmentName = "Finans Management",
                },
            };
        }
    }

}
