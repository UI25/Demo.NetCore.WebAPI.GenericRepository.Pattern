using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Site.Models.Models.V1.Customers
{
    public class Company : BaseEntity
    {
        [Required(ErrorMessage = "Name required!..")]
        [MaxLength(30, ErrorMessage = "Name is MaxLength 30")]
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address required!..")]
        [JsonPropertyName("Address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City required!..")]
        [JsonPropertyName("City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Country required!..")]
        [JsonPropertyName("Country")]
        public string Country { get; set; }
        [JsonPropertyName("Region")]
        public string Region { get; set; }
        [JsonPropertyName("PostalCode")]
        public string PostalCode { get; set; }
        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }
}
