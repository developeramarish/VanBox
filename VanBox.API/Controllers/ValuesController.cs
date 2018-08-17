using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VanBox.API.Data;

namespace VanBox.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public DataContext Context { get; set; }
        public ValuesController(DataContext context)
        {
            this.Context = context;

        }
        // GET api/values
        [HttpGet]
        public IActionResult GetValues()
        {
            var data = Context.Values.ToList();
            return Ok(data);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetValues(int id)
        {
            var data = Context.Values.FirstOrDefault(x=>x.Id == id);
            return Ok(data);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
