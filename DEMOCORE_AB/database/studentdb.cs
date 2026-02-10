using Microsoft.EntityFrameworkCore;

namespace DEMOCORE_AB.database
{
    public class studentdb:DbContext
    {
        public studentdb(DbContextOptions options) : base(options)
        {

        }
    }
}
