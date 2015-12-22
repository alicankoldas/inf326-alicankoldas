namespace DamacanaStoreAPI4.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DamacanaStoreAPI4.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DamacanaStoreAPI4.Models.DamacanaStoreAPI4Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DamacanaStoreAPI4.Models.DamacanaStoreAPI4Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Products.AddOrUpdate(x => x.Id,
                new Product() { Id = 1, name = "Guzelpinar",price = 19.95M },
                new Product() { Id = 2, name = "Erikli", price = 5.99M },
                new Product() { Id = 3, name = "Tasdelen", price = 6.99M }
        );

        }
    }
}
