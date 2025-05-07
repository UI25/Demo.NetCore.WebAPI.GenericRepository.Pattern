using Microsoft.EntityFrameworkCore;
using Site.Models.Data;
using Site.WebAPI.Repositories.Interfaces;
using Site.WebAPI.Services.Interfaces;
using Site.WebAPI.Services.Repositories;

namespace Site.WebAPI.Extensions
{
    public static class ServiceExtension
    {
        
        public static IServiceCollection AddDIServices(this IServiceCollection Services, IConfiguration Configuration)
        {
            var StoreDB = Configuration.GetConnectionString("StoreDB");
            
            Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(StoreDB,
                    m => m.MigrationsAssembly("Site.Models"));
            });

            Services.AddScoped<IUnitOfWork, UnitOfWork>();
            Services.AddScoped<IProductRepository, ProductRepository>();

            return Services;
        }
    }
}
