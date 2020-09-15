using System;
using System.Collections.Generic;

namespace SpaAPI.Models
{
    public partial class PreOrder
    {
        public int PreOrderId { get; set; }
        public int? OutletId { get; set; }
        public int CustomerId { get; set; }
        public int ListServicePreOrderId { get; set; }
        public int ListProductPreOrder { get; set; }
        public DateTime? Appointment { get; set; }
        public DateTime? DateFounded { get; set; }
        public double? TotalPrice { get; set; }
    }
}
