using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSite.Api.Models
{
    public class PurchaseOrder
    {
        public int Id { get; set; }

        public int VendorId { get; set; }

        public Vendor Vendor { get; set; }
    }
}
