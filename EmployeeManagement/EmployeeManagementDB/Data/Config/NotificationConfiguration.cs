using EmployeeManagementDB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementDatabase.Data.Config
{
    public class NotificationConfiguration : IEntityTypeConfiguration<Notification>
    {
        public void Configure(EntityTypeBuilder<Notification> builder)
        {
            builder.HasKey(e => e.NotificationId);

            builder.Property(e => e.NotificationMessage)
                .HasColumnType("VarChar(Max)");

            builder.Property(e => e.NotificationDate)
               .HasColumnType("Date");

            builder.ToTable("Notification");
        }



    }
}
