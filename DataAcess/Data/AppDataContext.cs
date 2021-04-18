using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DataAcess.Model;

namespace DataAcess.Data
{
    public class AppDataContext : DbContext
    {

        public AppDataContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<EntradaSaida> EntradaSaidas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoUnitario> TipoUnitarios { get; set; }
        public DbSet <Colaborador> Colaboradores { get; set; }
    }
}
