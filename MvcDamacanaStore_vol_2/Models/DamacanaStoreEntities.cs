using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcDamacanaStore.Models
{
    public class DamacanaStoreEntities : DbContext
    {  
        public DbSet<Product> Products { get; set; }
        public DbSet<Bayii> Bayiler { get; set; }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public System.Data.Entity.DbSet<MvcDamacanaStore.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }

        public System.Data.Entity.DbSet<MvcDamacanaStore.ViewModels.ShoppingCartRemoveViewModel> ShoppingCartRemoveViewModels { get; set; }

    }
}



      
