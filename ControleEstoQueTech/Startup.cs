using DataAcess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ControleEstoQueTech
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddDbContext<AppDataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Default")));
           services.AddScoped<IProdutoRepository, ProdutoRepository>();

           services.AddScoped<IFornecedoresRepository, FornecedoresRepository>();
           services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            //services.AddScoped<IUnitOfWork, UnitOfWork>();
           
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mzc0OTQ1QDMxMzgyZTM0MmUzME1vQ0R2UHdqdEp6b1lTMVNxSG92NjQ0S3kwcGVWc2dYTmdkUWV3YW12OWs9");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
