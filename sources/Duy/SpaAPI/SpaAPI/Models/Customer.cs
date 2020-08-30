using System;
using System.Collections.Generic;

namespace SpaAPI.Models
{
    public partial class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerImage { get; set; }
        public double? CustomerHeight { get; set; }
        public double? CustomerWeight { get; set; }
        public string Job { get; set; }
        public string Hobbies { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? Dob { get; set; }
        public string Cmnd { get; set; }
        public double? MuscleRatio { get; set; }
        public double? BellyfatRatio { get; set; }
        public double? FatRatio { get; set; }
        public int? UserId { get; set; }
    }
}
