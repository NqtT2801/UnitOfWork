using UnitOfWorkPattern.Core.IRepository;
using UnitOfWorkPattern.Core.IUnitOfWork;
using UnitOfWorkPattern.Core.Repository;

namespace UnitOfWorkPattern.Data
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _context;

        public IUserRepository Users {get; private set;}
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Users = new UserRepository(context);
        }
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
