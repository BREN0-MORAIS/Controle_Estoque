using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DataAcess
{
    public class Fornecedor
    {

        public Fornecedor()
        {

        }
        private AppDataContext db;
        public Fornecedor(AppDataContext db)
        {
            this.db = db;
        }
        public int FornecedorId { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}
