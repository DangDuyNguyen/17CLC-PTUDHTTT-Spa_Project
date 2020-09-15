using System;
using System.Collections.Generic;

namespace SpaAPI.Models
{
    public partial class Outlet
    {
        public int OutletId { get; set; }
        public string OutletName { get; set; }
        public string OutletAddress { get; set; }
        public int OutletStatus { get; set; }
        public int ManagerId { get; set; }
        public int? KinhDo { get; set; }
        public int? ViDo { get; set; }
    }
}
