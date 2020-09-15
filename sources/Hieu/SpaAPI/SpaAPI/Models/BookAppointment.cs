using System;
using System.Collections.Generic;

namespace SpaAPI.Models
{
    public partial class BookAppointment
    {
        public int BookId { get; set; }
        public int CustomerId { get; set; }
        public int ConsultantId { get; set; }
        public int List_Service { get; set; }
        public int List_Product { get; set; }
        public DateTime? DateAppointment { get; set; }
        public DateTime? DateFoundedAppointment { get; set; }
        public int StaffId { get; set; }
        public int OutletId { get; set; }
        public double? Rating { get; set; }
        public string Feedback { get; set; }
        public double? TotalPrice { get; set; }
        public int? StatusBook { get; set; }
    }
}
