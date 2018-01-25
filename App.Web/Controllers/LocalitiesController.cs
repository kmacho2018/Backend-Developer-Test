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
using App.Model.Models;

namespace App.Web.Controllers
{
    public class LocalitiesController : ApiController
    {
        private DbTestEntities db = new DbTestEntities();

        // GET: api/Localities
        public IQueryable<Locality> GetLocalities()
        {
            return db.Localities;
        }

        // GET: api/Localities/5
        [ResponseType(typeof(Locality))]
        public IHttpActionResult GetLocality(int id)
        {
            Locality locality = db.Localities.Find(id);
            if (locality == null)
            {
                return NotFound();
            }

            return Ok(locality);
        }

        // PUT: api/Localities/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLocality(int id, Locality locality)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != locality.Id)
            {
                return BadRequest();
            }

            db.Entry(locality).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LocalityExists(id))
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

        // POST: api/Localities
        [ResponseType(typeof(Locality))]
        public IHttpActionResult PostLocality(Locality locality)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Localities.Add(locality);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = locality.Id }, locality);
        }

        // DELETE: api/Localities/5
        [ResponseType(typeof(Locality))]
        public IHttpActionResult DeleteLocality(int id)
        {
            Locality locality = db.Localities.Find(id);
            if (locality == null)
            {
                return NotFound();
            }

            db.Localities.Remove(locality);
            db.SaveChanges();

            return Ok(locality);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LocalityExists(int id)
        {
            return db.Localities.Count(e => e.Id == id) > 0;
        }
    }
}