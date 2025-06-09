using WebApplication2.Data;

namespace WebApplication2.Services;

public class StudentsServices :IStudentsSevices
{
    private readonly AppDbContext _context;

    public StudentsServices(AppDbContext context)
    {
        _context = context;
    }
}