using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToddlerScan.Data;
using ToddlerScan.Domain;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace localWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToddlerTripController : ControllerBase
    {
        private ToddlerScanContext context = new ToddlerScanContext();

        // GET: api/ToddlerTrip
        [HttpGet]
        public IEnumerable<ToddlerTrip> Get()
        {
            var toddlerTrip = context.ToddlerTrips.ToList();
            return toddlerTrip;
        }

        // GET: api/ToddlerTrip/5
        [HttpGet("{id}", Name = "Get")]
        public ToddlerTrip Get(int id)
        {
            using (context)
            {
                var toddlerTrips = context.ToddlerTrips.ToList();
                foreach (var toddlerTrip in toddlerTrips)
                {
                    if (toddlerTrip.Id.Equals(id))
                    {
                        return toddlerTrip;
                    }
                }
                return null;
            }
        }

        // POST: api/ToddlerTrip
        [HttpPost]
        public async void Post([FromBody] ToddlerTrip toddlerTrip)
        {
            using (context)
            {
                EntityEntry<ToddlerTrip> toddlerTripEntry = context.ToddlerTrips.Add(toddlerTrip);
                await context.SaveChangesAsync();
            }
        }

        // PUT: api/ToddlerTrip/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ToddlerTrip toddlerTrip)
        {
            using (context)
            {
                var toddlerTripToChange = (from t in context.ToddlerTrips
                                       where t.Id == id
                                       select t).Single();
                toddlerTripToChange = toddlerTrip;

                context.Update(toddlerTripToChange);
                context.SaveChanges();
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (context)
            {

                (from t in context.ToddlerTrips
                 where t.Id == id
                 select t)
                 .ToList()
                 .ForEach(t => context.ToddlerTrips.Remove(t));

                context.SaveChanges();

            }
        }
    }
}
