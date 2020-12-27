using System;
using System.Collections.Generic;

namespace DataAcess
{
    public class EstoqueRepository : IEstoqueRepository
    {
        private AppDataContext _db;

        public EstoqueRepository(AppDataContext db)
        {
            this._db = db;
        }

        public void Add(Estoque entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Estoque entity)
        {
            throw new NotImplementedException();
        }

        public Estoque Get(Estoque entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Estoque> GetAll()
        {
            throw new NotImplementedException();
        }

        public Estoque GetId(Estoque entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Estoque Entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Estoque entity)
        {
            throw new NotImplementedException();
        }

    }
}
