using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Models.Models
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
