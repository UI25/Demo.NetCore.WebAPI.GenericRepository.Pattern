using Site.Models.Models.V1.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Site.Models.Models.V1.Employees;

namespace Site.Models.Models.V1.Orders
{
    public class OrderDetail : BaseEntity
    {
        public DateTime ProcessTime { get; set; } = DateTime.Now;
        public string ProcessName { get; set; }
        public string Description { get; set; }
        public Guid OrderId { get; set; }
        public Guid EmployeeId { get; set; }
        public Order Order { get; set; }
        public Employee Employee { get; set; }

    }
}
