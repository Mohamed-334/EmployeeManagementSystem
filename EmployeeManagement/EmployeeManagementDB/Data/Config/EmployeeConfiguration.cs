using EmployeeManagementDatabase.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDatabase.Data.Config
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.ProfilePhoto)
                .HasColumnType("Image")
                .IsRequired(false);

            builder.Property(e => e.FirstName)
                .HasColumnType("VarChar")
                .HasMaxLength(30);

            builder.Property(e => e.LastName)
               .HasColumnType("VarChar")
               .HasMaxLength(30);
            builder.HasData(LoadData());

            builder.HasOne(e => e.Manager)
                .WithMany(e => e.EmployeesOfManager)
                .HasForeignKey(e => e.ManagerId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Employee");
        }

        private List<Employee> LoadData()
        {
            return new List<Employee>
            {

                new Employee
                {
                    Id = "1",
                    FirstName = "Mohamed",
                    LastName = "Ibrahim",
                    UserName = "MohamedIbrahim" ,
                    Email = "mohamedaboelez334@gmail.com" ,
                    PasswordHash ="EntaMalOmk.1516" ,
                    PhoneNumber = "01068706845",
                    Address ="Assuit",
                    PositionId = 1,
                },

                new Employee
                {
                    Id = "2",
                    FirstName = "Youssef",
                    LastName = "Ibrahim",
                    UserName = "YoussefIbrahim" ,
                    Email = "Youssef1234.com" ,
                    PasswordHash ="EntaMalOmkTany.1516",
                    PhoneNumber = "01049834561",
                    Address ="Sharm AlSheikh",
                    PositionId = 2,
                },
                new Employee
                {

                    Id = "3",
                    FirstName = "Khaled",
                    LastName = "Alaa",
                    UserName = "KhaledAlaa" ,
                    Email = "Khaled333@gmail.com" ,
                    PasswordHash ="EntaMalOmkTalet.1516" ,
                    PhoneNumber = "0118735194",
                    Address ="Cairo",
                    PositionId = 3,
                },

                new Employee
                {
                    Id = "4",
                    FirstName = "Anas",
                    LastName = "Mohamed",
                    UserName = "AnasMohamed" ,
                    Email = "AnasMohamed784.com" ,
                    PasswordHash ="EntaMalOmk4.1516" ,
                    PhoneNumber = "01249834561",
                    Address ="New Capital",
                    PositionId = 4,
                },

                new Employee
                {
                    Id = "5",
                    FirstName = "Khaled",
                    LastName = "Ahmed",
                    UserName = "KhaledAhmed" ,
                    Email = "KhaledAhmed@gmail.com" ,
                    PasswordHash ="EntaMalOmk5.1516" ,
                    PhoneNumber = "01532943571",
                     Address ="Alex",
                    PositionId = 5,
                },

                new Employee
                {
                    Id = "6",
                    FirstName = "Alaa",
                    LastName = "Osama",
                    UserName = "AlaaOsama" ,
                    Email = "Alaa841.com" ,
                    PasswordHash ="EntaMalOmkTany.1516" ,
                    PhoneNumber = "0107835641",
                    Address ="Kafr Alsheikh",
                    PositionId = 6,
                },
                new Employee
                {
                    Id = "7",
                    FirstName = "Admin",
                    LastName = "1",
                    UserName = "Admin1" ,
                    NormalizedUserName = "ADMIN1",
                    Email = "Admin1@gmail.com" ,
                    NormalizedEmail ="ADMIN@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PasswordHash ="AQAAAAEAACcQAAAAENRk/0rWj9s9DDgr3hBGlpYR1MG2yXRFRtxLnu3B8Oh4sNCuukNQ9+wp5e7KseC8eA==" ,
                    PhoneNumber = "01068873164",
                    Address ="Alex",
                    PositionId = 7,
                }
            };
        }


    }
}
