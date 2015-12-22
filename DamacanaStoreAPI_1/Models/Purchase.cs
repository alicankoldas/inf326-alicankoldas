using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DamacanaStoreAPI4.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        [Required]
        public int userId { get; set; }
        public DateTime createdOn { get; set; }

        public decimal totalPrice;
    }
}