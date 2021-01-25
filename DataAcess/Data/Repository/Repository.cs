using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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
        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual T Get(int id)
        {
            return null;
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public T GetId(int id)
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

     
    }
}
