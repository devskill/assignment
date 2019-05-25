using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class TrainingContext : DbContext
    {
        private readonly string _connectionString;

        public TrainingContext()
        {
            _connectionString = "Server =.\\SQLEXPRESS; Database = EFTest; Integrated Security = True";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder
          modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<StudentCourse>().HasKey(x => new { x.StudentId, x.CourseId });
            modelBuilder.Entity<StudentCourse>().HasOne(u => u.Student).WithMany(c => c.StudentCourses).HasForeignKey(c => c.StudentId);
            modelBuilder.Entity<StudentCourse>().HasOne(c => c.Course).WithMany(u => u.CourseStudents).HasForeignKey(c => c.CourseId);
            modelBuilder.Entity<Course>().HasMany(c => c.Topics).WithOne(u => u.Course).HasForeignKey(c => c.CourseId);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
