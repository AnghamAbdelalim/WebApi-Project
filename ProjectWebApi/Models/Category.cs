using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectWebApi.Models
{
    public class Category
    {
        public int Id{ get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
       [JsonIgnore]
        public virtual List<Product> products { get; set; }
    }
}