using System;
using System.Collections.Generic;

namespace SpaAPI.Models
{
    public partial class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string StaffImage { get; set; }
        public string Address { get; set; }
        public DateTime? JoinedDay { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? Dob { get; set; }
        public string Cmnd { get; set; }
        public int? StaffType { get; set; }
        public int? StaffStatus { get; set; }
        public int? UserId { get; set; }
    }
}
