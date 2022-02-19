using Microsoft.EntityFrameworkCore;

namespace LawPavilionTask.Model
{
    public class LoginContext : DbContext
    {
        public LoginContext() : base()
        {

        }

        public DbSet<Login> logins { get; set; }
        public DbSet<UserRegister> userRegisters { get; set; }
    }
}
