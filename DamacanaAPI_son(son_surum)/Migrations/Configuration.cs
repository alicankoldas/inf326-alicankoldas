namespace DamacanaAPI_son.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DamacanaAPI_son.Models;
    using damacanaAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DamacanaAPI_son.Models.DamacanaAPI_sonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DamacanaAPI_son.Models.damacanaAPIContext";
        }

        protected override void Seed(DamacanaAPI_son.Models.DamacanaAPI_sonContext context)
        {
            context.Products.AddOrUpdate(x => x.Id,
                         new Product()
                         {
                             Id = 1,
                             Name = "Madran",
                             Price = 3.99M
                         },
                        
                         new Product()
                         {
                             Id = 2,
                             Name = "Kizilcik",
                             Price = 2.99M
                         },
                         new Product()
                         {
                             Id = 3,
                             Name = "Tasdelen",
                             Price = 4.55M
                         },
                         new Product()
                         {
                             Id = 4,
                             Name = "Guzelpinar",
                             Price = 3.99M
                         });
                         
        }
    }
}
