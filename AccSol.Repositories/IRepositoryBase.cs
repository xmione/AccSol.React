using System.Linq.Expressions;

namespace AccSol.Repositories
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}