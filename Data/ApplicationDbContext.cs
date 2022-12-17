using Microsoft.EntityFrameworkCore;
using Models;
using Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Student> students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //send Student Data 
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Rishabh",
                    LastName = "Patel",
                    Email = "rgp@gmail.com",
                    DOB = new DateTime(1998, 07, 31),
                    gender =Gender.Male,
                    DepartmentId= 1,
                    PhotoPath = "Images/Path"

                });
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 2,
                    FirstName = "smit",
                    LastName = "Patel",
                    Email = "smit@gmail.com",
                    DOB = new DateTime(1998, 07, 31),
                    gender = Gender.Male,
                    DepartmentId = 2,
                    PhotoPath = "Images/Path"

                });


        }

    }
}
