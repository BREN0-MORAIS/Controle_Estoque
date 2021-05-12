using DataAcess.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAcess.Data.Repository.IRepository
{
    public interface IEstoqueRepository : IRepository<Estoque>
    {
        Estoque Get(Expression<Func<Estoque,bool>> Logic);
       
    }
}
