using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.DTO;

namespace WebApplication2.Services;

public class CoursesServices :ICoursesServices
{
    private AppDbContext _context;

    public CoursesServices(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<CourseDTO>> GetCourses()
    {
        return await _context.Courses
            .Include(c => c.Enrollments)
            .ThenInclude(c => c.Student)
            .Select(c => new CourseDTO
            {
                Id = c.Id,
                Title = c.Title,
                Teacher = c.Teacher,
                Students = c.Enrollments.Select(e => new StudentDTO
                {
                    Id = e.Student.ID,
                    FirstName = e.Student.FirstName,
                    LastName = e.Student.LastName,
                    Email = e.Student.Email,
                    

                }).ToList()
            })
            .ToListAsync();
    }
}