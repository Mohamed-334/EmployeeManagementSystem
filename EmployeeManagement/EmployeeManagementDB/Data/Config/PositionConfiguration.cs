using EmployeeManagementDB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementDatabase.Data.Config
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.PositionName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(false);

            builder.HasMany(p => p.Employees)
                .WithOne(e => e.Position)
                .HasForeignKey(e => e.PositionId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            builder.HasIndex(e => e.PositionName).IsUnique();
            builder.HasData(LoadData());

            builder.ToTable("position");
        }

        private List<Position> LoadData()
        {
            return new List<Position>
            {
                new Position
                {
                    Id = 1,
                    PositionName = "DotNet Developer",
                    DepartmentId = 2
                },

                new Position
                {
                     Id = 2,
                    PositionName = "PM Back-end",
                    DepartmentId = 7,
                },
                new Position
                {

                    Id = 3,
                    PositionName = "Laravel Developer",
                    DepartmentId = 2
                },

                new Position
                {
                     Id = 4,
                    PositionName = "React Developer",
                    DepartmentId = 4
                },

                new Position
                {
                    Id = 5,
                    PositionName = "Angular Developer",
                    DepartmentId = 4
                },

                new Position
                {
                    Id = 6,
                    PositionName = "PM Front-end ",
                    DepartmentId = 7
                },
                new Position
                {
                     Id = 7,
                    PositionName = "Admin",
                    DepartmentId = 6
                }
            };
        }


    }
}
