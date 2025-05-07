using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Models.Models.V1.Customers
{
    public class CustomerPhone : BaseEntity
    {
        public string PhoneName { get; set; }
        public string PhoneNumber { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
