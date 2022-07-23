using Model;
using System.Linq.Expressions;

namespace Repository
{
    public interface IRepository<T> : IDisposable where T : Entity
    {
        Task<IEnumerable<T>> Get(bool track = true);
        Task<IEnumerable<T>> Search(Expression<Func<T, bool>> predicate, bool track = true);
        Task<T> GetById(Guid id, bool track = true);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(T entity);
    }
}
