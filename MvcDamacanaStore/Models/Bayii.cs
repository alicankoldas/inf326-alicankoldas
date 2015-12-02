using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcDamacanaStore.Models
{
    public class Bayii
    {
        public int BayiiId { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}