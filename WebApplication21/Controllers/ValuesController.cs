using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication21.Data;
using WebApplication21.Models;

namespace WebApplication21.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<IHouse> Get()
        {
            return Repository.GetHouse();
        }

        public IHouse GetHouseById(int id)
        {
            return Repository.GetHouseById(id);
        }

        [HttpGet]
        [Route("GetRange/{pos}/count/{count}")]
        public IEnumerable<IHouse> Get(int pos, int count, int args = 0)
        {
            return Repository.GetHouseRange(pos, count);
        }

        // POST api/value
        [HttpPost]
        public void Post([FromBody] House value)
        {
            Repository.AddHouse(value);
        }

        // PUT api/value/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/value/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
