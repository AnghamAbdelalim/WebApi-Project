using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ProjectWebApi.Models;

namespace ProjectWebApi.Controllers
{
    public class ProductCartsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/ProductCarts
        public IQueryable<ProductCart> GetProductCarts()
        {
            return db.ProductCarts;
        }

        // GET: api/ProductCarts/5
        [ResponseType(typeof(ProductCart))]
        public IHttpActionResult GetProductCart(int id)
        {
            ProductCart productCart = db.ProductCarts.Find(id);
            if (productCart == null)
            {
                return NotFound();
            }

            return Ok(productCart);
        }

        // PUT: api/ProductCarts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProductCart(int id, ProductCart productCart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != productCart.ID)
            {
                return BadRequest();
            }

            db.Entry(productCart).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductCartExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ProductCarts
        [ResponseType(typeof(ProductCart))]
        public IHttpActionResult PostProductCart(ProductCart productCart)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ProductCarts.Add(productCart);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = productCart.ID }, productCart);
        }

        // DELETE: api/ProductCarts/5
        [ResponseType(typeof(ProductCart))]
        public IHttpActionResult DeleteProductCart(int id)
        {
            ProductCart productCart = db.ProductCarts.Find(id);
            if (productCart == null)
            {
                return NotFound();
            }

            db.ProductCarts.Remove(productCart);
            db.SaveChanges();

            return Ok(productCart);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductCartExists(int id)
        {
            return db.ProductCarts.Count(e => e.ID == id) > 0;
        }
    }
}