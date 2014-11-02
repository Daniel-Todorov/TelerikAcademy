using System;
namespace BullsAndCows.Data.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> All();

        T Find(object id);

        void Add(T entity);

        T Delete(T entity);

        T Delete(object id);

        void Update(T entity);

        void Detach(T entity);

        int SaveChange();
    }
}
