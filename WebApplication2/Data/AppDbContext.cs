using Microsoft.EntityFrameworkCore;
using WebApplication2.models;

namespace WebApplication2.Data;

public class AppDbContext : DbContext
{
    DbSet<Student>? Students { get; set; }
    DbSet<Course>? Courses { get; set; }
    DbSet<Enrollment>? Enrollments { get; set; }
    public AppDbContext(DbContextOptions options) : base(options)
    {
        ModelBuilder.Entity<Enrollment>()
            .HasKey(e => new { e.Student_Id, e.Course_Id });
        ModelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Student)
            .WithMany(e => e.Enrollments)
            .HasForeignKey(e => e.Student_Id);
        ModelBuilder.Entity<Enrollment>()
            .HasOne(e => e.Course)
            .WithMany(e => e.Enrollments)
            .HasForeignKey(e => e.Course_Id);
    }
}