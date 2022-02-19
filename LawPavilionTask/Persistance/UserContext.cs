using LawPavilionTask.Model;
using Microsoft.EntityFrameworkCore;

namespace LawPavilionTask.Persistance
{
    public class UserContext : DbContext
    {
        public DbSet<User> users { get; set; }

        public UserContext(DbContextOptions options)
            : base(options)
        {
        }
    }
}
