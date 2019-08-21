using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ToddlerScan.Data;
using ToddlerScan.Domain;

namespace localWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private ToddlerScanContext context = new ToddlerScanContext();

        // GET: api/Trip
        [HttpGet]
        public IEnumerable<Trip> Get()
        {
            var trips = context.Trips.ToList();
            return trips;
        }

        // GET: api/Trip/5
        [HttpGet("{id}", Name = "GetTrip")]
        public Trip Get(int id)
        {
            using (context)
            {
                var trips = context.Trips.ToList();
                foreach (var trip in trips)
                {
                    if (trip.Id.Equals(id))
                    {
                        return trip;
                    }
                }
                return null;
            }
        }

        // POST: api/Trip
        [HttpPost]
        public async void Post([FromBody] Trip trip)
        {
            using (context)
            {
                EntityEntry<Trip> tripEntity = context.Trips.Add(trip);
                await context.SaveChangesAsync();
            }
        }

        // PUT: api/Trip/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Trip trip)
        {
            using (context)
            {
                var tripToChange = (from t in context.Trips
                                           where t.Id == id
                                           select t).Single();
                tripToChange = trip;

                context.Update(tripToChange);
                context.SaveChanges();
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (context)
            {

                (from t in context.Trips
                 where t.Id == id
                 select t)
                 .ToList()
                 .ForEach(t => context.Trips.Remove(t));

                context.SaveChanges();

            }
        }
    }
}
