using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        private ToddlerScanContext context = new ToddlerScanContext();
        [HttpGet]
        //GET: api/Teacher
        public IEnumerable<Teacher> Get()
        {
            using(context)
            {
                var teachers = context.Teachers.ToList();
                return teachers;
            }
        }

        // GET: api/Teacher/5
        [HttpGet("{id}", Name = "GetTeacher")]
        public Teacher Get(int id)
        {
            using (context)
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
        public async void Post([FromBody] Teacher teacher)
        {
            using (context)
            {
                EntityEntry<Teacher> teacherEntery = context.Teachers.Add(teacher);
                await context.SaveChangesAsync();
            }

        }

        // PUT: api/Teacher/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Teacher teacher)
        {
            using (context)
            {
                var teacherToChange = (from t in context.Teachers
                                       where t.Id == id
                                       select t).Single();
                teacherToChange.FirstName = teacher.FirstName;
                teacherToChange.LastName = teacher.LastName;

                context.Update(teacherToChange);
                context.SaveChanges();
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (context)
            {
                (from t in context.Teachers
                 where t.Id == id
                 select t)
                 .ToList()
                 .ForEach(t => context.Teachers.Remove(t));

                context.SaveChanges();
            }

        }

    }
}
