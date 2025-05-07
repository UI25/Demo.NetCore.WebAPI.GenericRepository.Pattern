using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Site.Models.Models.V1.Customers;
using Site.Models.Models.V1.Employees;
using Site.Models.Models.V1.Settings;

namespace Site.Models.Models.V1.Orders
{
    public class Order : BaseEntity
    {
        [Required]
        public DateTime OrderDate { get; set; } = DateTime.Now;
        [Required]
        [ForeignKey("OrderTypeId")]
        public Guid OrderTypeId { get; set; }
        [Required]
        public Guid EmployeeId { get; set; }
        [Required]
        public Guid CustomerId { get; set; }


        public OrderType OrderType { get; set; }
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }



    }
}
