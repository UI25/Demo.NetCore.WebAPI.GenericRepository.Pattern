using Site.Models.Models.V1.Orders;
using Site.Models.Models.V1.Settings;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Models.Models.V1.Products
{
    public class ProductList : BaseEntity
    {
        [Required]
        public string SerialNumber { get; set; } = string.Empty;
        [Required]
        public Guid UnitId { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        public bool Status { get; set; }
        public Guid ProductId { get; set; }
        public Guid StoreId { get; set; }
        public Product Product { get; set; }
        public Store Store { get; set; }
        public UnitType UnitType { get; set; }
        public List<OrderItem> OrderDetails { get; } = new List<OrderItem>();
    }
}
