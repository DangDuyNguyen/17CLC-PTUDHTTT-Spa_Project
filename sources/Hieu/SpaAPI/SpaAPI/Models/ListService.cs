using System;
using System.Collections.Generic;

namespace SpaAPI.Models
{
    public partial class ListService
    {
        public int ListServiceId { get; set; }
        public int BedId { get; set; }
        public string Time { get; set; }
        public int StaffId { get; set; }
        public int ServiceId { get; set; }
    }
}
