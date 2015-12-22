using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DamacanaStoreAPI4.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public decimal totalAmount { get; set; }

        // Foreign Key
        public int ProductId { get; set; }
        // Navigation property
        public virtual Product Product { get; set; }
    }
}