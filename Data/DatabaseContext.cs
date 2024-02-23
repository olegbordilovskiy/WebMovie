using Microsoft.EntityFrameworkCore;

namespace WebMovie.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
    }
}
