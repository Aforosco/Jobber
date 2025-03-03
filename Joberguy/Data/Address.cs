using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joberguy.Data
{
    [Table("Address")]
    public class Address
	{
        public int Id { get; set; }
        public string StreetAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        
    }
}

