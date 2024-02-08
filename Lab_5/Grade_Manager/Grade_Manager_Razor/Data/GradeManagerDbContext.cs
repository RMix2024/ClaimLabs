using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Grade_Manager_Razor.Models;
using System.ComponentModel.DataAnnotations.Schema;


namespace Grade_Manager_Razor.Data
{
    public class GradeManagerDbContext :DbContext
    {
      

        public GradeManagerDbContext(DbContextOptions<GradeManagerDbContext> options)
           : base(options)
        {
        }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            

            
            modelBuilder.Entity<ClassRoom>().HasData
            (
                
                new ClassRoom
                {
                    ClassRoomId = 1,
                    Name = "C#",
                   
                },
                new ClassRoom
                {
                    ClassRoomId = 2,
                    Name = "Java"
                }
               
            );

            modelBuilder.Entity<Student>().HasData
            (
                new Student
                {
                    StudentId = 1,
                    Name = "JimBob",
                    ClassRoomId = 1
                },
                new Student
                {
                    StudentId = 2,
                    Name = "Bradley",
                    ClassRoomId = 1
                },
                new Student
                {
                    StudentId = 3,
                    Name = "Steven",
                    ClassRoomId = 1
                },
                new Student
                {
                    StudentId = 4,
                    Name = "Jonathon",
                    ClassRoomId = 2
                },
                new Student
                {
                    StudentId = 5,
                    Name = "Heather",
                    ClassRoomId = 2
                },
                new Student
                {
                    StudentId = 6,
                    Name = "Warren",
                    ClassRoomId = 2
                }
                );

            modelBuilder.Entity<Assignment>().HasData
                (
                new Assignment
                {
                    AssignmentId = 1,
                    Name = "Lab_1",
                    IsComplete = false,
                    Grade = 0,
                    StudentId = 1
                },
                new Assignment
                {
                    AssignmentId = 2,
                    Name = "Lab_2",
                    IsComplete = false,
                    Grade = 0,
                    StudentId = 1
                },
                new Assignment
                {
                    AssignmentId = 3,
                    Name = "Lab_3",
                    IsComplete = false,
                    Grade = 0,
                    StudentId = 1
                },
                new Assignment
                {
                    AssignmentId = 4,
                    Name = "Lab_4",
                    IsComplete = false,
                    Grade = 0,
                    StudentId = 1
                }
                );
                
        }

        public DbSet<Assignment> Assignments { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<ClassRoom> ClassRooms { get; set; }
    }
}
