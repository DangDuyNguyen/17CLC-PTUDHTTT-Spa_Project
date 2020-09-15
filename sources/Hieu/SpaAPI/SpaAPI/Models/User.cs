using System;
using System.Collections.Generic;

namespace SpaAPI.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Pwd { get; set; }
        public int? UserType { get; set; }
    }
}
