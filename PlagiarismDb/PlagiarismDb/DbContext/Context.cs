using Microsoft.EntityFrameworkCore;

namespace PlagiarismDb
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
    }
}
