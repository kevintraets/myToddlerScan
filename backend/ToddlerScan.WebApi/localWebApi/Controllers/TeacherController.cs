using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToddlerScan.Data;
using ToddlerScan.Domain;

namespace localWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        [HttpGet]
        //GET: api/Teacher
        public IEnumerable<Teacher> Get()
        {
            using(var context = new ToddlerScanContext())
            {
                var teachers = context.Teachers.ToList();
                return teachers;
            }
        }

        // GET: api/Teacher/5
        [HttpGet("{id}", Name = "GetTeacher")]
        public Teacher Get(int id)
        {
            using (var context = new ToddlerScanContext())
            {
                var teachers = context.Teachers.ToList();
                foreach (var teacher in teachers)
                {
                    if (teacher.Id.Equals(id))
                    {
                        return teacher;
                    }

                }

                return null;
            }
        }

        // POST: api/Teacher
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Teacher/5
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
