using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcDamacanaStore.Models;
using System.ComponentModel.DataAnnotations;

namespace MvcDamacanaStore.ViewModels
{
    public class ShoppingCartViewModel
    {
        public int id { get; set; }
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}