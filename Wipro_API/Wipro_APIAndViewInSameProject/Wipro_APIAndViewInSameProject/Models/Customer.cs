﻿using System.ComponentModel.DataAnnotations;

namespace Wipro_APIAndViewInSameProject.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }
        public int CustomerAge { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
    }
}
