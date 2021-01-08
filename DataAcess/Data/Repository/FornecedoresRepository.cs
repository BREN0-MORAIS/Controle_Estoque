using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAcess
{
    public class FornecedoresRepository : IFornecedoresRepository
    {
        private AppDataContext _db;

        public FornecedoresRepository(AppDataContext db)
        {
            this._db = db;
        }

        public void Add(Fornecedor entity)
        {
            _db.Add(entity);
        }

        public void Delete(Fornecedor entity)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Fornecedor> GetAll()
        {

            return _db.Fornecedores.ToList();
        }

        public Fornecedor GetId(Fornecedor entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Fornecedor Entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Fornecedor entity)
        {
            throw new NotImplementedException();
        }

        Fornecedor IRepository<Fornecedor>.Get(Fornecedor entity)
        {
            throw new NotImplementedException();
        }
    }
}
