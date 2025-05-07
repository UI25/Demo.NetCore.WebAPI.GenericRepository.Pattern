using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Models.Models.V1.Customers
{
    public class CustomerAddress : BaseEntity
    {
        public string AddressName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
