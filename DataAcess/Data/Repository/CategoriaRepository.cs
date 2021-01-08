using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DataAcess
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDataContext _db;

        public CategoriaRepository(AppDataContext db)
        {
            _db = db;
        }
        public IEnumerable<Categoria> categorias => _db.Categorias.ToList();

        public void Add(Categoria entity)
        {
            _db.Add(entity);
        }

        public void Delete(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public Categoria Get(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> GetAll()
        {
           return _db.Categorias.ToList();
        }

       
        public Categoria GetId(Categoria entity)
        {
            var buscarId = _db.Categorias.FirstOrDefault(a => a.CategoriaId == entity.CategoriaId);

            return buscarId;
        }

        public void Remove(Categoria Entity)
        {
            Categoria buscar = GetId(Entity);

            _db.Remove(buscar);

        }
      

        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Categoria entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
