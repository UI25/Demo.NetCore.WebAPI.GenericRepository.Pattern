using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Site.Models.Models.V1.Products
{
    public class Category : BaseEntity
    {
        [Required]
        [MaxLength(30, ErrorMessage = "CategoryName is required")]
        [JsonPropertyName("CategoryName")]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
