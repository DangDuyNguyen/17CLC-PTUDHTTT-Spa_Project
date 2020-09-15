using System;
using System.Collections.Generic;

namespace SpaAPI.Models
{
    public partial class ProductCustomer
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Supplier { get; set; }
        public int? Price { get; set; }
        public string Code { get; set; }
        public string ProductDescription { get; set; }
    }
}
