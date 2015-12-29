using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DamacanaAPI_son.Models
{
    public class CartDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public DateTime AddedDate { get; set; }
    }
}