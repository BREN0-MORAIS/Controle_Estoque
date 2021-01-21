using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAcess
{
    public class Repository<T>: IRepository<T> where T : class
    {
        private readonly AppDataContext _db;
        internal DbSet<T> dbSet;

        public Repository(AppDataContext context)
        {
            _db = context;
            this.dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            //dbSet.Remove(entity);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }


        public void Get(int id)
        {
           
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public T GetId(T entity)
        {
            throw new NotImplementedException();
        }


        public void Save()
        {
            _db.SaveChanges();
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
