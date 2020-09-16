using System.Data.Entity;

namespace СРМ_Солюшнс_Task
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DBConnection")
        {

        }

        public DbSet<User> users { get; set; }
    }
}