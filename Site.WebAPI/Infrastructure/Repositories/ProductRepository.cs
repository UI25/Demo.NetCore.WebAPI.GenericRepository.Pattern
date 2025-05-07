using Site.Models.Data;
using Site.Models.Models.V1.Products;
using Site.WebAPI.Repositories.Interfaces;
using Site.WebAPI.Services.Interfaces;

namespace Site.WebAPI.Services.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbcontext) : base(dbcontext) 
        {
            
        }
    }
}
