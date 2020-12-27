using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAcess
{
    public class Fornecedor
    {
        private AppDataContext db;

        public Fornecedor(AppDataContext db)
        {
            this.db = db;
        }

        public int FornecedorId { get; set; }
        public string Empresa { get; set; }
        public IList<Produto> Produto { get; set; }

    }
}
