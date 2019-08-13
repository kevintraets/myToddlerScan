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
    public class ScanController : ControllerBase
    {
        private ToddlerScanContext context = new ToddlerScanContext();
        // GET: api/Scan
        [HttpGet]
        public IEnumerable<Scan> Get()
        {
            using (context)
            {
                var scans = context.Scans.ToList();
                return scans;
            }
        }

        // GET: api/Scan/5
        [HttpGet("{id}", Name = "Get")]
        public Scan Get(int id)
        {
            using (context)
            {
                var scans = context.Scans.ToList();
                foreach (var scan in scans)
                {
                    if (scan.Id.Equals(id))
                    {
                        return scan;
                    }
                }
                return null;
            }
        }

        // POST: api/Scan
        [HttpPost]
        public async void Post([FromBody] Scan scan)
        {
            using (context)
            {
                EntityEntry<Scan> scanEntery = context.Scans.Add(scan);
                await context.SaveChangesAsync();
            }
        }

        // PUT: api/Scan/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Scan scan)
        {
            using (context)
            {
                var scanToChange = (from s in context.Scans
                                    where s.Id == id
                                    select s).Single();
                scanToChange = scan;
                context.Update(scanToChange);
                context.SaveChanges();
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (context)
            {
                (from s in context.Scans
                 where s.Id == id
                 select s)
                 .ToList()
                 .ForEach(s => context.Scans.Remove(s));

                context.SaveChanges();
            }
        }
    }
}
