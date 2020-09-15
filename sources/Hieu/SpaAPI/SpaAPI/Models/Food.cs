using System;
using System.Collections.Generic;

namespace SpaAPI.Models
{
    public partial class Food
    {
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Calories { get; set; }
        public string Note { get; set; }
    }
}
