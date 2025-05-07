using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Site.Models.Models
{
    public class BaseEntity : IEntity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

        public BaseEntity()
        {
            Id= Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }
    }
}
