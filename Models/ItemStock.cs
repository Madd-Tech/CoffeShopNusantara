using System;
using System.Collections.Generic;

using System.Text;

namespace CoffeShopNusantara.Models
{
    public class ItemStock
    {
        public int IdItem { get; set; }
        public string Code { get; set; } = string.Empty;
        public string? Title { get; set; }
        public string? Measurement { get; set; }
        public double? Quantity { get; set; }
        public DateTime LastUpdate { get; set; }
        public string? IsDeleted { get; set; }
    }
}
