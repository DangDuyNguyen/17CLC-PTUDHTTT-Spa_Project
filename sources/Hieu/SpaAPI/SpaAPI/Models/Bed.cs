using System;
using System.Collections.Generic;

namespace SpaAPI.Models
{
    public partial class Bed
    {
        public int BedId { get; set; }
        public string BedName { get; set; }
        public int RoomManage { get; set; }
        public string BedDescription { get; set; }
    }
}
