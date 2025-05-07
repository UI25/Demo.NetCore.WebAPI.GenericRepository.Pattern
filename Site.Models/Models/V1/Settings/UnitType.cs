using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Models.Models.V1.Settings
{
    public class UnitType : BaseEntity
    {
        [Required]
        public Guid UnitId { get; set; }
        [Required]
        public string UnitName { get; set; }

        public UnitType()
        {
            UnitId = Guid.NewGuid();
        }

    }
}
