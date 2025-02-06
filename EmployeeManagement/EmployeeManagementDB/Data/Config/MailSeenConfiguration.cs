using EmployeeManagementDB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagementDatabase.Data.Config
{
    public class MailSeenConfiguration : IEntityTypeConfiguration<MailSeen>
    {
        public void Configure(EntityTypeBuilder<MailSeen> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Seen)
            .HasColumnType("bit");


            builder.HasOne(e => e.Employee)
                .WithMany(e => e.MailSeen)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(e => e.Report)
                .WithMany(e => e.MailSeen)
                .HasForeignKey(e => e.MailId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("MailSeen");
        }



    }
}
