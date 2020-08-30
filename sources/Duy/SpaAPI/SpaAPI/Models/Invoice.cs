using System;
using System.Collections.Generic;

namespace SpaAPI.Models
{
    public partial class Invoice
    {
        public int InvoiceId { get; set; }
        public int? ProductId { get; set; }
        public int? ServiceId { get; set; }
        public int CustomerId { get; set; }
        public int? OutletId { get; set; }
        public int? Total { get; set; }
        public DateTime? Date { get; set; }
        public string Room { get; set; }
        public string ConsultantId { get; set; }
    }
}
