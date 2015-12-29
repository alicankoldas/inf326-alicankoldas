using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using damacanaAPI.Models;

namespace DamacanaAPI_son.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<Product> Cartproducts { get; set; }
        public decimal TotalPrice { get; set; }
    }
}