using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DamacanaAPI_son.Models
{
    public class DamacanaAPI_sonContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public DamacanaAPI_sonContext() : base("name=DamacanaAPI_sonContext")
        {
        }

        public System.Data.Entity.DbSet<damacanaAPI.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<DamacanaAPI_son.Models.Cart> Carts { get; set; }

        public System.Data.Entity.DbSet<DamacanaAPI_son.Models.Purchase> Purchases { get; set; }
    
    }
}
