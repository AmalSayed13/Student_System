using Microsoft.EntityFrameworkCore;
using Student_System.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_System
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=.;Database=StudentSystem;Trusted_Connection=True;TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Course>()
        .HasOne(c => c.Department)
        .WithMany(d => d.Courses)
        .HasForeignKey(c => c.DeptName);

            modelBuilder.Entity<Course>()
                .HasOne(c => c.Instructor)
                .WithMany(i => i.Courses)
                .HasForeignKey(c => c.InsId);

            modelBuilder.Entity<CourseSession>()
                   .HasOne(c => c.instructor)
                   .WithMany(i => i.CourseSessions)
                   .HasForeignKey(c => c.InstractorId)
                   .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<CourseSessionAttendance>()
                .HasOne(csa => csa.CourseSession)
                .WithMany(cs => cs.courseSessionAttendances)
                .HasForeignKey(csa => csa.CourseSessionId);

            modelBuilder.Entity<CourseSessionAttendance>()
                .HasOne(csa => csa.Student)
                .WithMany(s => s.courseSessionAttendances)
                .HasForeignKey(csa => csa.StudentId);

            modelBuilder.Entity<Course_Student>()
                .HasKey(cs => new { cs.CourseId, cs.StudentId });

            modelBuilder.Entity<Course_Student>()
                .HasOne(cs => cs.course)
                .WithMany(c => c.Course_Students)
                .HasForeignKey(cs => cs.CourseId);

            modelBuilder.Entity<Course_Student>()
                .HasOne(cs => cs.student)
                .WithMany(s => s.course_Students)
                .HasForeignKey(cs => cs.StudentId);

            modelBuilder.Entity<Department>()
                    .HasKey(d => d.Name);
            modelBuilder.Entity<Department>()
            .HasMany(d => d.Instructors)
             .WithOne(i => i.Department)
             .HasForeignKey(i => i.DeptName)
             .OnDelete(DeleteBehavior.NoAction);
            

            modelBuilder.Entity<Instructor>()
                .HasMany(i => i.CourseSessions)
                .WithOne(cs => cs.instructor)
                .HasForeignKey(cs => cs.InstractorId);
            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //}
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseSession> CourseSessions { get; set; }
        public DbSet<CourseSessionAttendance> CourseSessionAttendances { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course_Student> CourseStudents { get; set; }
  
    }
}
