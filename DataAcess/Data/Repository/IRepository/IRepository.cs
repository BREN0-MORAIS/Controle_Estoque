using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcess.Data.Repository.IRepository
{
    public interface IRepository<T>
    {

        void  Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        T Get(T entity);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(Expression<Func<T, bool>> a);
 


    }
}
