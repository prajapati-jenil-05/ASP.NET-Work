using Microsoft.EntityFrameworkCore;
using mvc_core.Models;
using System.Data;

namespace mvc_core.database
{
    //new things DbContext
    public class student_db : DbContext
    {
        public student_db(DbContextOptions<student_db> options) : base(options)
        {
        }

        public DbSet<student_model> studentable { get; set; }
    }
}



