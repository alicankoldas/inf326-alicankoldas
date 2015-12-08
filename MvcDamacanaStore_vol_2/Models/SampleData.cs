using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MvcDamacanaStore.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<DamacanaStoreEntities>
    {
        protected override void Seed(DamacanaStoreEntities context)
        {


            var Bayiler = new List<Bayii>
            {
                new Bayii { Name = "Cekmekoy"},
                new Bayii { Name = "İ.M.E.S"},
                new Bayii { Name = "Yenidoğan"},
                new Bayii { Name = "Çayırönü"},
                new Bayii { Name = "Ihlamurkuyu"},
                new Bayii { Name = "Vergi Dairesi"},
                new Bayii { Name = "Doğanevler"},
                new Bayii { Name = "Tavukçuyolu"},
                new Bayii { Name = "Esenşehir"}
            };

            new List<Product>
            {
                new Product {Id = 1, Name = "Madran", Bayii = Bayiler.Single(g => g.Name == "Cekmekoy"),Price = 4.99M },
                new Product {Id = 2, Name = "Bozdogan Madran", Bayii = Bayiler.Single(g => g.Name == "Cekmekoy"), Price = 4.99M},
                new Product {Id = 3, Name = "Kızılcık Madran", Bayii = Bayiler.Single(g => g.Name == "Cekmekoy"), Price = 4.99M},                
                new Product { Id = 4, Name = "Kaltun Madran ", Bayii = Bayiler.Single(g => g.Name == "Cekmekoy"), Price = 4.99M},
                new Product { Id = 5, Name = "Munzur", Bayii = Bayiler.Single(g => g.Name == "İ.M.E.S"), Price = 4.99M},
                new Product { Id = 6, Name = "Taşdelen", Bayii = Bayiler.Single(g => g.Name == "İ.M.E.S"), Price = 4.99M},
                new Product { Id = 7, Name = "Sızma", Bayii = Bayiler.Single(g => g.Name == "İ.M.E.S"), Price = 4.99M},
                new Product { Id = 8, Name = "Niksar", Bayii = Bayiler.Single(g => g.Name == "İ.M.E.S"), Price = 4.99M},
                new Product { Id = 9, Name = "Çobanpınar", Bayii  = Bayiler.Single(g => g.Name == "Yenidoğan"), Price = 4.99M },
                new Product { Id = 10, Name = "Erikli", Bayii  = Bayiler.Single(g => g.Name == "Yenidoğan"), Price = 4.99M },
                new Product { Id = 11, Name = "Saka", Bayii  = Bayiler.Single(g => g.Name == "Çayırönü"), Price = 4.99M },
                new Product { Id = 12, Name = "AquaFina", Bayii  = Bayiler.Single(g => g.Name == "Çayırönü"), Price = 4.99M },
                new Product { Id = 13, Name = "Turkuaz", Bayii  = Bayiler.Single(g => g.Name == "Ihlamurkuyu"), Price = 4.99M },
                new Product { Id = 14, Name = "Nestle", Bayii  = Bayiler.Single(g => g.Name == "Ihlamurkuyu"), Price = 4.99M },
                new Product { Id = 15, Name = "Pınar", Bayii  = Bayiler.Single(g => g.Name == "Vergi Dairesi"), Price = 4.99M },
                new Product { Id = 16, Name = "Serinsu", Bayii  = Bayiler.Single(g => g.Name == "Vergi Dairesi"), Price = 4.99M },
                new Product { Id = 17, Name = "Durusu", Bayii  = Bayiler.Single(g => g.Name == "Vergi Dairesi"), Price = 4.99M },
                new Product { Id = 18, Name = "SUde", Bayii  = Bayiler.Single(g => g.Name == "Vergi Dairesi"), Price = 4.99M },
                new Product { Id = 19, Name = "BerrakSU", Bayii  = Bayiler.Single(g => g.Name == "Esenşehir"), Price = 4.99M },
                new Product { Id = 20, Name = "Karasu", Bayii  = Bayiler.Single(g => g.Name == "Esenşehir"), Price = 4.99M },
                new Product { Id = 21, Name = "Aksu", Bayii  = Bayiler.Single(g => g.Name == "Tavukçuyolu"), Price = 4.99M },
                new Product { Id = 22, Name = "Gürsu", Bayii  = Bayiler.Single(g => g.Name == "Tavukçuyolu"), Price = 4.99M },
                new Product { Id = 23, Name = "Soğuksu", Bayii  = Bayiler.Single(g => g.Name == "Doğanevler"), Price = 4.99M },
                new Product { Id = 24, Name = "Elasu", Bayii  = Bayiler.Single(g => g.Name == "Doğanevler"), Price = 4.99M}
            }.ForEach(g => context.Products.Add(g));

        }
    }
}
