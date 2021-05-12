using DataAcess.Data.Repository.IRepository;
using DataAcess.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAcess.Data.Repository
{
    public class EstoqueRepository : Repository<Estoque>, IEstoqueRepository
    {
        private AppDataContext _db { get; set; }
        public EstoqueRepository(AppDataContext db) : base(db)
        {
            _db = db;
        }
        public IEnumerable<Estoque>  GetAll()
        {
          return  _db.Estoques.Include("Produto").ToList();
            
        }

        public Estoque Get(Expression<Func<Estoque, bool>> Logic)
        {
            return _db.Estoques.Where(Logic).FirstOrDefault();
        }

       
    }
}
