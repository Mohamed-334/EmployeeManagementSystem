using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementDatabase.Data.Config
{
    public class UserRolesConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasKey( e => new {e.UserId,e.RoleId});
            builder.HasData(LoadData());
            builder.ToTable("UserRole");
        }
        private List<IdentityUserRole<string>> LoadData()
        {
            return new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>
                {
                    UserId = "7",
                    RoleId = "2" ,
                }
            };
        }
    }

}
