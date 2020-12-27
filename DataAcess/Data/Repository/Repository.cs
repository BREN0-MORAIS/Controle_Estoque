using System;
using System.Collections.Generic;

namespace DataAcess
{
    public class Repository<T>: IRepository<T>
    {
        private readonly AppDataContext _Context;

        public Repository(AppDataContext context)
        {
            _Context = context;
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Get(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetId(T entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(T Entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _Context.SaveChanges();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        T IRepository<T>.Get(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
