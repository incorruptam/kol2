using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}