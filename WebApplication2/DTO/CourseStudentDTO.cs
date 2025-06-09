namespace WebApplication2.DTO;

public class CourseStudentDTO
{
    public StudentDTO Student { get; set; }
    public List<CourseDTO> Courses { get; set; }
}