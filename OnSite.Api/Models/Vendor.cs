﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSite.Api.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Phone { get; set; }

        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public ICollection<VendorProduct> VendorProducts { get; set; }
    }
}
