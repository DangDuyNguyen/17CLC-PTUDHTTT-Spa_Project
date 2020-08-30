using System;
using System.Collections.Generic;

namespace SpaAPI.Models
{
    public partial class ServiceCustomer
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string ServiceImage { get; set; }
        public double? Price { get; set; }
        public int TherapistId { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceTime { get; set; }
        public string BreakTime { get; set; }
        public string Code { get; set; }
    }
}
