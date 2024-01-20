using UnitOfWorkPattern.Core.IRepository;
using UnitOfWorkPattern.Data;
using UnitOfWorkPattern.Model;

namespace UnitOfWorkPattern.Core.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
