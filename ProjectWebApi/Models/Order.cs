using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectWebApi.Models
{
    public class Order
    {

        public int Id { get; set; }
        public string Date { get; set; }
      public string customerID { get; set; }

        [ForeignKey("customerID")]
        public virtual IdentityUser customer { get; set; }
        public virtual List<ProductOrder> ProductOrders { get; set; }
    }
}