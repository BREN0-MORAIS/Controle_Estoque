using DataAcess.Data;
using DataAcess.Data.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcess
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDataContext _db;

        internal DbSet<T> dbSet;


        public Repository(AppDataContext db)
        {
            _db = db;

            this.dbSet = db.Set<T>();

        }


        public void Add(T entity)
        {
           

            dbSet.Add(entity);
            _db.SaveChanges();
        }

        public virtual T Get(T entity)
        {
            return null;
        }

        
        public virtual T Get(int id)
        {
            return null;
        }


        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> a)
        {
            return dbSet.Where(a).ToList();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
            _db.SaveChanges();

        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
            _db.SaveChanges();
        }
    }
}
