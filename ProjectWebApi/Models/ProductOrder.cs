using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectWebApi.Models
{
        public class ProductOrder
        {
            public int ID { get; set; }
            [JsonIgnore]

            public virtual Order Order { get; set; }
            [JsonIgnore]

            public virtual Product Product { get; set; }
        }
    
}