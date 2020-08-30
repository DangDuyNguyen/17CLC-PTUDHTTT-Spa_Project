using System;
using System.Collections.Generic;

namespace SpaAPI.Models
{
    public partial class ListProduct
    {
        public int ListProductId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }
    }
}
