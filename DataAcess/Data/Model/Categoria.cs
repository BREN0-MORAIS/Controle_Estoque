using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAcess
{
    public class Categoria
    {
        public Categoria()
        {

        }
        public int CategoriaId { get; set; }
     
        public string Descricao { get; set; }
        //public IList<Produto> Produto { get; set; }
    }
}
