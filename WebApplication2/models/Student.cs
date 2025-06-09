using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.models;

public class Student
{

    public int ID { get; set; }

    public String FirstName { get; set; }

    public String LastName { get; set; }

    public String? Email { get; set; }
    public ICollection<Enrollment>? Enrollments { get; set; } = new List<Enrollment>();
}