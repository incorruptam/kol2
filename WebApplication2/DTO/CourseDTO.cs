namespace WebApplication2.DTO;

public class CourseDTO
{
    public int Id { get; set; }
    public String Title { get; set; }
    public String Teacher { get; set; }
    public List<StudentDTO> Students { get; set; }
}