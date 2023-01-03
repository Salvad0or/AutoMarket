using System.Collections.Generic;

namespace AutoMarket.Dal.Interfaces
{
    public interface IBaseRepository<T>
    {
        bool Create(T entity);
        T Get(int id);
        IEnumerable<T> Select();
        bool Delete(T entity);

        void Update(T entity);
    }
}
