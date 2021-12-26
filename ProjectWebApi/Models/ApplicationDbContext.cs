using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectWebApi.Models
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext() : base("CS")
        {

        }
        public virtual DbSet<Order> orders { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<ProductCart>ProductCarts { get; set; }
        public virtual DbSet<ProductOrder> ProductOrders { get; set; }
    }
}