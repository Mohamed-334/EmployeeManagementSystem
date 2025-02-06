using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementDatabase.Data.Config
{
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(LoadData());
            builder.ToTable("Role");
        }
        private List<IdentityRole> LoadData()
        {
            return new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Id = "1",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                },
                 new IdentityRole
                {
                    Id = "3",
                    Name = "Manager",
                    NormalizedName = "MANAGER",
                },
            };
        }
    }

}
