using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Newtonsoft.Json.Linq;
using ToddlerScan.Data;
using ToddlerScan.Domain;

namespace localWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToddlerController : ControllerBase
    {

        private ToddlerScanContext context = new ToddlerScanContext();
        // GET: api/Toddler
        [HttpGet]
        public IEnumerable<Toddler> Get()

        {

            using (context)
            {
                var toddlers = context.Toddlers.ToList();
                return toddlers;
            }
        }

        // GET: api/Toddler/5
        [HttpGet("{id}", Name = "GetToddler")]
        public Toddler Get(int id)
        {
            using (context)
            {
                var toddlers = context.Toddlers.ToList();
                foreach (var toddler in toddlers)
                {
                    if (toddler.Id.Equals(id))
                    {
                        return toddler;
                    }
                }
                return null;
            }
        }

        // POST: api/Toddler
        [HttpPost]
        public async void Post([FromBody] Toddler toddler)
        {
            using (context)
            {
                EntityEntry<Toddler> teacherEntery = context.Toddlers.Add(toddler);
                await context.SaveChangesAsync();
            }

        }

        // PUT: api/Toddler/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Toddler toddler)
        {
            using (context)
            {
                var toddlerToChange = (from t in context.Toddlers
                                       where t.Id == id
                                       select t).Single();
                toddlerToChange.FirstName = toddler.FirstName;
                toddlerToChange.LastName = toddler.LastName;
                toddlerToChange.Grade = toddler.Grade;

                context.Update(toddlerToChange);
                context.SaveChanges();
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (context)
            {

                (from t in context.Toddlers
                 where t.Id == id
                 select t)
                 .ToList()
                 .ForEach(t => context.Toddlers.Remove(t));

                context.SaveChanges();

            }
        }
    }
}
