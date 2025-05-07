using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Models.Models.V1.Products
{
    public class SubCategory : BaseEntity
    {
        [Required]
        public Guid CategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
    }
}
