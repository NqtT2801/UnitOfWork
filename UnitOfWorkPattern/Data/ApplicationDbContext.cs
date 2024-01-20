using Microsoft.EntityFrameworkCore;
using UnitOfWorkPattern.Model;

namespace UnitOfWorkPattern.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
