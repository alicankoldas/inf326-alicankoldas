using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDamacanaStore.Models;
 
namespace MvcDamacanaStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        DamacanaStoreEntities storeDB = new DamacanaStoreEntities();
        public ActionResult Index()
        {
            var bayii = storeDB.Bayiler.ToList();
            return View(bayii);
        }
        //
        // GET: /Store/Browse
        public ActionResult Browse(string genre)
        {
            var genreModel = storeDB.Bayiler.Include("Products").Single(g => g.Name == genre);

            return View(genreModel);
        }
        //
        // GET: /Store/Details
        public ActionResult Details(int id)
        {
            var product = storeDB.Products.Find(id);
            return View(product);
        }
    }
}