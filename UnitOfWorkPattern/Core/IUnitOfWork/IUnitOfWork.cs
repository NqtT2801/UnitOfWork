using UnitOfWorkPattern.Core.IRepository;

namespace UnitOfWorkPattern.Core.IUnitOfWork
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        Task CompleteAsync();
    }
}
