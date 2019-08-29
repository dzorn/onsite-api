using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSite.Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public ICollection<VendorProduct> Vendors { get; set; }
    }
}
