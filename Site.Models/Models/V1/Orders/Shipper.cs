using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Models.Models.V1.Orders
{
    public class Shipper : BaseEntity
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}
