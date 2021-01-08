using System.Collections.Generic;

namespace DataAcess
{
    public interface IRepository<T>
    {
         void Add(T entity);
         void Remove(T entity);
         T Get(T entity);
         IEnumerable<T> GetAll();
         T GetId(T entity);
         void Update(T entity);
         void Save();
    }
}
