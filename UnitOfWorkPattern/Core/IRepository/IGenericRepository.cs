namespace UnitOfWorkPattern.Core.IRepository
{
    public interface IGenericRepository<T>
    {
        Task<IEnumerable<T>> All();
        Task<T> GetById(Guid id);
        Task<bool> Add (T entity);
        Task<bool> Delete (Guid id);
        Task<bool> Upsert (T entity);
    }
}
