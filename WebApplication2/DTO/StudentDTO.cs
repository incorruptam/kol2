using WebApplication2.models;

namespace WebApplication2.DTO;

public class StudentDTO
{
    public int Id { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String? Email { get; set; }
    public ICollection<Enrollment> Enrollments { get; set; }
}