using DataAcess.Data.Repository;
using DataAcess.Data.Repository.IRepository;
using DataAcess.Libraries;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcess
{
    public static class DI
    {
        public static void InjetarDependencia(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddMemoryCache();
            services.AddSession(options => {

                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();      
            services.AddScoped<IEntradaSaidaRepository, EntradaSaidaRepository>();      
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();      
            services.AddScoped<ITipoUnitarioRepository, TipoUnitarioRepository > ();      
            services.AddScoped<IProdutoRepository, ProdutoRepository > ();
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            services.AddScoped<IEstoqueRepository, EstoqueRepository>();
            services.AddScoped<Login>();
       
        }
    }
}
