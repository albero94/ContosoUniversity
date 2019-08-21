using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Models
{
    public class ContosoUniversityContext : DbContext
    {
        public ContosoUniversityContext(DbContextOptions<ContosoUniversityContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversity.Models.Course> Course { get; set; }
        public DbSet<ContosoUniversity.Models.Enrollment> Enrollment { get; set; }
        public DbSet<ContosoUniversity.Models.Student> Student { get; set; }
        public DbSet<ContosoUniversity.Models.Department> Department { get; set; }
        public DbSet<ContosoUniversity.Models.Instructor> Instructor { get; set; }
        public DbSet<ContosoUniversity.Models.OfficeAssignment> OfficeAssignment { get; set; }
        public DbSet<ContosoUniversity.Models.CourseAssignment> CourseAssignment { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseAssignment>()
                .HasKey(c => new { c.CourseID, c.InstructorID });
        }

    }

}
