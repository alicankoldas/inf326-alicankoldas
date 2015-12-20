using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DamacanaStoreAPI_1.Models
{
    public class Cart
    {
        public int id { get; set; }
        [Required]
        public int userId { get; set; }
        public List<KeyValuePair<Product, int>> items { get; set; }
        
        public decimal totalAmount;
    }
}