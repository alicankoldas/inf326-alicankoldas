using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcDamacanaStore.Models
{
    public class Purchase
    {
        [Key]
        public int id { get; set; }
        public int userId { get; set; }
        public DateTime createdOn { get; set; }
        public List<KeyValuePair<Product, int> > items { get; set; }
        public decimal totalPrice;
    }
}