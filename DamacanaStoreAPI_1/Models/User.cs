using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DamacanaStoreAPI_1.Models
{
    public class User
    {
        public int id { get; set; }
        [Required]
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}