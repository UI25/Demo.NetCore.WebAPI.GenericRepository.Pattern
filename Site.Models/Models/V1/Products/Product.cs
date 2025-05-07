using Site.Models.Models.V1.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Models.Models.V1.Products
{
    public class Product : BaseEntity
    {
        [Required]
        public string ProductNo { get; set; }
        [Required]
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
        public Guid SubCategoryId { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }

    }
}
