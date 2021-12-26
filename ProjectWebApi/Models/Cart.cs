using Microsoft.AspNet.Identity.EntityFramework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectWebApi.Models
{
        public class Cart
        {
            public int ID { get; set; }
           // [JsonIgnore]
           // public virtual List<Product> Products { get; set; } = new List<Product>();
           [ForeignKey("user")]
            public string userId { get; set; }
            public virtual IdentityUser user { get; set; }
          // public virtual List<ProductCart> ProductCarts { get; set; }

        }
    }
