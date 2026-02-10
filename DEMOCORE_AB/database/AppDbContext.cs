using Microsoft.EntityFrameworkCore;
using DEMOCORE_AB.Models;

namespace DEMOCORE_AB.database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Student> students { get; set; }
    }
}
