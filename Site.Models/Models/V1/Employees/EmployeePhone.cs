using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Models.Models.V1.Employees
{
    public class EmployeePhone : BaseEntity
    {
        public string PhoneName { get; set; }
        public string PhoneNumber { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
