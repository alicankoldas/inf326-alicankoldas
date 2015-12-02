using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace MvcDamacanaStore.Models
{
    [Bind(Exclude = "Id")]
    public class Product
    {
            [ScaffoldColumn(false)]
            public int Id { get; set; }
            [Required(ErrorMessage = "A Product Name is required")]
            [StringLength(160)]
            public string Name { get; set; }
            [Required(ErrorMessage = "Price is required")]
            [Range(0.01, 100.00,
                ErrorMessage = "Price must be between 0.01 and 100.00")]
            public decimal Price { get; set; }
            public virtual Bayii Bayii { get; set; }
            
    }
}