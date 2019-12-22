using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PenoApp.Data;
using PenoApp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PenoApp.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        PenoContext _context = new PenoContext();
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Student> Get()
        {

            var blogs = _context.Students
                .Where(id =>id.Id==2)
                .Include(st => st.LecAndStudents)
                .ToList();
                return  blogs;      
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> Get(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/<controller>/5
        [HttpPut()]
        public void Put([FromBody]Student value)
        {
            _context.Entry(value).State = EntityState.Added;
            _context.SaveChanges();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
