using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using ToddlerScan.Data;
using ToddlerScan.Domain;

namespace localWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToddlerController : ControllerBase
    {
        // GET: api/Toddler
        [HttpGet]
        public IEnumerable<Toddler> Get()

        {

            using (var context = new ToddlerScanContext())
            {
                var toddlers = context.Toddlers.ToList();
                return toddlers;
            }
        }

        // GET: api/Toddler/5
        [HttpGet("{id}", Name = "Get")]
        public Toddler Get(int id)
        {
            using (var context = new ToddlerScanContext())
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
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Toddler/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
