using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DamacanaStoreAPI_1.Models
{
    public class Product
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public decimal price { get; set; }
    }
}