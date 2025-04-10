using Microsoft.EntityFrameworkCore;
using UniversityManagement.Models;

namespace UniversityManagement.Data
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
    }
}
