using System.Collections.Generic;
using System.Linq;
using CourseProjectApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseProjectApp.Controllers
{
    [Route("api/[controller]")]
    public class RestController : Controller
    {
        private readonly ProfileContext _context;
        public RestController(ProfileContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Individual> Get()
        {
            return _context.Individuals.ToList();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
