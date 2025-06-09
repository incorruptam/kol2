using System.ComponentModel.DataAnnotations;

namespace WebApplication2.models;
public class Course
{

    public int Id { get; set; }

    public String Title { get; set; }

    public String? Credits { get; set; }

    public String Teacher { get; set; }
    public ICollection<Enrollment>? Enrollments { get; set; } = new List<Enrollment>();
}