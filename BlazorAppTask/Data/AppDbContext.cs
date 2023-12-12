using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BlazorAppTask.Data
{
    // AppDbContext.cs
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Enrolled> Enrolled { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships and constraints here
            modelBuilder.Entity<Enrolled>()
                .HasKey(e => e.Id);

            // Add other configurations as needed
        }


        public void AddStudent(Student student)
        {
            Students.Add(student);
            SaveChanges();
        }

        public void AddFaculty(Faculty faculty)
        {
            Faculty.Add(faculty);
            SaveChanges();
        }

        public void AddClass(Class course)
        {
            Classes.Add(course);
            SaveChanges();
        }

        public void AddEnrolled(Enrolled enrollment)
        {
            Enrolled.Add(enrollment);
            SaveChanges();
        }
    }

}
