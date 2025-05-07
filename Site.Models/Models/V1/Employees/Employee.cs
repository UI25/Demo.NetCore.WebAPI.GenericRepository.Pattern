using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Models.Models.V1.Employees
{
    public class Employee : BaseEntity
    {
        public string EmpolyeeNo { get; set; }
        public string NationalIdNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtery { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }

        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public string Notes { get; set; }
        public string ReportTo { get; set; }
        public string PhotoUrl { get; set; }

    }
}
