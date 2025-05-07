using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Models.Models.V1.Settings
{
    public class OrderType : BaseEntity
    {
        [Required]
        public Guid OrderTypeId { get; set; }
        [Required]
        public string OrderTypeName { get; set; }

        public OrderType()
        {
            OrderTypeId = Guid.NewGuid();
        }
    }
}
