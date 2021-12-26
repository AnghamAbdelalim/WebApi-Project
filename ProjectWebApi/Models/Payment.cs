using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectWebApi.Models
{
    public class Payment
    {
        public int id { get; set; }
       // public int Amount { get; set; }
        public int CreditCadrdNumber { get; set; }
        public virtual IdentityUser UserName { get; set; }
        public string Bank { get; set; }
        public string Branch { get; set; }
        public DateTime Expire_Date { get; set; }
        public int CCV { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}