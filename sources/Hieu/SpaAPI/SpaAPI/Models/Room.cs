using System;
using System.Collections.Generic;

namespace SpaAPI.Models
{
    public partial class Room
    {
        public int RoomId { get; set; }
        public string RoomName { get; set; }
        public int? RoomType { get; set; }
        public string RoomDescription { get; set; }
    }
}
