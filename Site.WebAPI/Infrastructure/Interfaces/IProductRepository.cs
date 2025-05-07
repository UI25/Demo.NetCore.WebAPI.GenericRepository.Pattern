using Site.Models.Models.V1.Products;
using Site.WebAPI.Repositories.Interfaces;

namespace Site.WebAPI.Services.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
    }
}
