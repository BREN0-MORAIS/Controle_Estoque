using DataAcess.Data.Repository.IRepository;
using DataAcess.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DataAcess.Data.Repository
{
    public  class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        public readonly AppDataContext _db;

        public CategoriaRepository(AppDataContext db): base(db)
        {
            this._db = db;
        }

        public IEnumerable<SelectListItem> GetCategoriaList()
        {
            return _db.Categorias.Select(i => new SelectListItem()
            {
                Text = i.Nome,
                Value = i.Id.ToString()
            });
        }

}
}
