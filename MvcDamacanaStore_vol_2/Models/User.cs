using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcDamacanaStore.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Name { get; set; }
    }
}