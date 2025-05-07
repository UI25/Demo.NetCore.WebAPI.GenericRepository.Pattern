using Site.Models.Models.V1.Products;
using Site.WebAPI.Infrastructure.ModelDtos.V1.Products;

namespace Site.WebAPI.Services
{
    public interface IProductService
    {
        Task<bool> CreateProduct(ProductDto productDto);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(Guid productId);
        Task<bool> UpdateProduct(Product product);
        Task<bool> DeleteProduct(Guid productId);
    }
}
