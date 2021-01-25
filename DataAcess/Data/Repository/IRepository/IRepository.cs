using System.Collections.Generic;

namespace DataAcess
{
    public interface IRepository<T>
    {
         void Add(T entity);
         void Remove(T entity);
         IEnumerable<T> GetAll();
         T GetId(int i);
         void Update(T entity);
         void Save();
    }
}
