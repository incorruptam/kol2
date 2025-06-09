using WebApplication2.DTO;
using WebApplication2.models;

namespace WebApplication2.Services;

public interface ICoursesServices
{
    Task<List<CourseDTO>> GetCourses();
}