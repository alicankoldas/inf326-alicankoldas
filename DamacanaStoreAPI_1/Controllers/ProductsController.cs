using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DamacanaStoreAPI4.Models;

namespace DamacanaStoreAPI4.Controllers
{
    public class ProductsController : ApiController
    {
        private DamacanaStoreAPI4Context db = new DamacanaStoreAPI4Context();

        // GET: api/Products
        public IQueryable<ProductDTO> GetProducts()
        {
            var products = from b in db.Products
                           select new ProductDTO()
                    {
                        Id = b.Id,
                        Name = b.name
                    };
            return products ;
        }

        // GET: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            var product =  db.Products.Include(b => b.Id).Select(b =>
                new ProductDetailDTO()
                {
                    Id = b.Id,
                    Name = b.name
                }).SingleOrDefault(b => b.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
  
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(int id)
        {
            return db.Products.Count(e => e.Id == id) > 0;
        }
    }
}