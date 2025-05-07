using Site.WebAPI.Repositories.Interfaces;
using Site.Models.Models.V1.Products;
using Site.WebAPI.Infrastructure.ModelDtos.V1.Products;
using AutoMapper;

namespace Site.WebAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        public IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork,
                              IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> CreateProduct(ProductDto productDto)
        {
            if (productDto != null)
            {
                Product product = _mapper.Map<Product>(productDto);

                await _unitOfWork.Products.Create(product);

                var result = _unitOfWork.SaveChangesAsync();

                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public async Task<bool> DeleteProduct(Guid productId)
        {
            if(productId != Guid.Empty)
            {
                var product = await _unitOfWork.Products.GetById(productId);
                if (product != null)
                {
                    await _unitOfWork.Products.Delete(productId);

                    var result = _unitOfWork.SaveChangesAsync();

                    if (result != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }              
            }
            return false;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var productList = await _unitOfWork.Products.GetAll();
            
            
            return productList;
        }

        public async Task<Product> GetProductById(Guid productId)
        {
            if (productId != Guid.Empty)
            {
                var productDetails = await _unitOfWork.Products.GetById(productId);

                if(productDetails != null)
                {
                    return productDetails;
                }
            }
            return null;
        }

        public async Task<bool> UpdateProduct(Product productDetails)
        {
            if (productDetails != null)
            {
                var product = await _unitOfWork.Products.GetById(productDetails.Id);
                if (product != null)
                {
                    product.Id = productDetails.Id;
                    product.ProductNo = productDetails.ProductNo;
                    product.Name = productDetails.Name;
                    product.ImageUrl = productDetails.ImageUrl;
                    product.Description = productDetails.Description;
                    product.CategoryId = productDetails.CategoryId;
                    product.SubCategoryId = productDetails.SubCategoryId;

                    await _unitOfWork.Products.Update(product.Id, product);

                    var result = _unitOfWork.SaveChangesAsync();

                    if (result != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
