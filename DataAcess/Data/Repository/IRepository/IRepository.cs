using System;
using System.Collections.Generic;
using System.Linq.Expressions;

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
         IEnumerable<T> GetAll(Expression<Func<T, bool>> a);
    }
}
