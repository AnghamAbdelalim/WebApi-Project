using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectWebApi.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        //public int CategoryID { get; set; }
        public virtual Category CategoryID { get; set; }
        [JsonIgnore]
        public virtual List<ProductOrder> Productorder { get; set; }
        [JsonIgnore]
        public virtual List<ProductCart> ProductCarts { get; set; }

    }
}