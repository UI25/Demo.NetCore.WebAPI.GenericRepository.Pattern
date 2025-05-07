using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.WebAPI.Infrastructure.ModelDtos.V1.Products
{
    public class ProductDto
    {
        public Guid Id { get; set; } 
        public string ProductNo { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public Guid CategoryID { get; set; }
        public Guid SubCategoryId { get; set; }

    }
}
