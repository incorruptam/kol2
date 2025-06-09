using WebApplication2.DTO;

namespace WebApplication2.Services;

public interface IStudentsSevices
{
    Task<List<StudentDTO>> GetStudents();
}
