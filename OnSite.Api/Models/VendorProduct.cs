using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSite.Api.Models
{
    public class VendorProduct
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }

        public int VendorId { get; set; }
        public int ProductId { get; set; }

        public Vendor Vendor { get; set; }
        public Product Product { get; set; }
    }
}
