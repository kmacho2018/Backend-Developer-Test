using App.Model.Models;
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

namespace App.Web.Controllers
{
    public class IncidentsController : ApiController
    {
        private DbTestEntities db = new DbTestEntities();

        // GET: api/Incidents
        public IEnumerable<Incident> GetIncidents()
        {
            int take = 100, skip = 0;
            string sort = "Asc";

            if (this.Request != null)
            {
                var queryString = this.Request.GetQueryNameValuePairs();

                if (queryString.Any())
                {
                    if (queryString.Any(x => x.Key == "Take"))
                    {
                        take = int.Parse(queryString.FirstOrDefault(x => x.Key == "Take").Value);
                    }

                    if (queryString.Any(x => x.Key == "Skip"))
                    {
                        skip = int.Parse(queryString.FirstOrDefault(x => x.Key == "Skip").Value);
                    }

                    if (queryString.Any(x => x.Key == "Sort"))
                    {
                        sort = queryString.FirstOrDefault(x => x.Key == "Sort").Value;
                    }
                }
            }

            if (sort == "Asc")
            {
                return db.Incidents.Where(x => x.IsArchive == false || x.IsArchive == null).ToList().Skip(skip).Take(take).OrderBy(x => x.Kind);
            }
            else
            {
                return db.Incidents.Where(x => x.IsArchive == false || x.IsArchive == null).ToList().Skip(skip).Take(take).OrderByDescending(x => x.Kind);
            }
        }

        // GET: api/Incidents1/1/archive
        [Route("api/Incidents/{IncidentId}/archive")]
        [HttpPost]
        public string GetIncidents(int IncidentId)
        {
            Incident incident = db.Incidents.Find(IncidentId);
            incident.IsArchive = true;
            db.SaveChanges();

            return string.Format("Incident {0} archived.", IncidentId);
        }

        // GET: api/Incidents/5
        [ResponseType(typeof(Incident))]
        public IHttpActionResult GetIncident(int id)
        {
            Incident incident = db.Incidents.Find(id);
            if (incident == null)
            {
                return NotFound();
            }

            return Ok(incident);
        }

        // PUT: api/Incidents/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutIncident(int id, Incident incident)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != incident.Id)
            {
                return BadRequest();
            }

            db.Entry(incident).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!IncidentExists(id))
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

        // POST: api/Incidents
        [ResponseType(typeof(Incident))]
        public bool PostIncident(Incident incident)
        {
            if (!ModelState.IsValid)
            {
                return false;//BadRequest(ModelState);
            }

            incident.HappenedAt = DateTime.Now;

            db.Incidents.Add(incident);
            db.SaveChanges();

            return true;//CreatedAtRoute("DefaultApi", new { id = incident.Id }, incident);
        }

        // DELETE: api/Incidents/5
        [ResponseType(typeof(Incident))]
        public IHttpActionResult DeleteIncident(int id)
        {
            Incident incident = db.Incidents.Find(id);
            if (incident == null)
            {
                return NotFound();
            }

            db.Incidents.Remove(incident);
            db.SaveChanges();

            return Ok(incident);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool IncidentExists(int id)
        {
            return db.Incidents.Count(e => e.Id == id) > 0;
        }
    }
}