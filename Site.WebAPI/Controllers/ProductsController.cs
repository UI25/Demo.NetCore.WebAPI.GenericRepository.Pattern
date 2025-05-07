using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Site.Models.Models.V1.Products;
using Site.WebAPI.Infrastructure.ModelDtos.V1.Products;
using Site.WebAPI.Services;

namespace Site.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        ///<summary>
        ///Get the List of product
        ///</summary>
        [HttpGet]
        public async Task<IActionResult> GetProductList()
        {
            var products = await _productService.GetAllProducts();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        ///<summary>
        ///Get Product by Id
        ///</summary>
        ///<param name="productId"></param>
        ///<returns></returns>
        [HttpGet("{productId}")]
        public async Task<IActionResult> GetProductsById(Guid productId)
        {
            var product = await _productService.GetProductById(productId);
            if (product != null)
            {
                return Ok(product);
            }
            else
            {
                return BadRequest();
            }
        }

        ///<summary>
        ///Add a new product
        ///</summary>
        ///<param name="product"></param>
        ///<returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductDto productDto)
        {
            var isProductCreated = await _productService.CreateProduct(productDto);

            if (isProductCreated)
            {
                return Ok(isProductCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        ///<summary>
        ///Uptade the product
        ///</summary>
        ///<returns></returns>
        ///
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            if (product != null)
            {
                var isProductCreated = await _productService.UpdateProduct(product);
                if (!isProductCreated)
                {
                    return Ok(isProductCreated);
                }
                return BadRequest();               
            }
            else
            {
                return BadRequest();
            }
        }

        ///<summary>
        ///Delete product by Id
        ///</summary>
        ///<param name="productId"></param>
        ///<returns></returns>
        [HttpDelete("{productId}")]
        public async Task<IActionResult> DeleteProduct(Guid productId)
        {
            var isproductDeleted = await _productService.DeleteProduct(productId);

            if (isproductDeleted)
            {
                return Ok(isproductDeleted);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
