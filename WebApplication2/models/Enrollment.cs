using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication2.models;

public class Enrollment
{
    public int Student_Id { get; set; }
    public virtual Student? Student { get; set; }
    public int Course_Id { get; set; }
    public virtual Course? Course { get; set; }
    public DateTime EnrollmentDate { get; set; }
}