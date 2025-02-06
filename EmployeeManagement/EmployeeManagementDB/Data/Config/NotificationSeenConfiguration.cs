using EmployeeManagementDB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementDatabase.Data.Config
{
    public class NotificationSeenConfiguration : IEntityTypeConfiguration<NotificationSeen>
    {
        public void Configure(EntityTypeBuilder<NotificationSeen> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Seen)
            .HasColumnType("bit");


            builder.HasOne(e => e.Employee)
                .WithMany(e => e.UserNotification)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Notification)
                .WithMany(e => e.UserNotification)
                .HasForeignKey(e => e.NotificationId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasQueryFilter(e => !e.Seen);
            builder.ToTable("NotificationSeen");
        }



    }
}
