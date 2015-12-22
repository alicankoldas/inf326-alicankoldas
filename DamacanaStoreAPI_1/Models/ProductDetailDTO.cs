using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DamacanaStoreAPI4.Models
{
    public class ProductDetailDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Uretim_yili { get; set; }
        public decimal Price { get; set; }

    }
}