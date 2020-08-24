using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pokedex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        // GET api/pokemon
        [HttpGet]
        public ActionResult<IEnumerable<pokemon>> Get()
        {
            return new pokemon[] { "pokemon1", "pokemon2" };
        }

        // GET api/pokemon/5
        [HttpGet("{id}")]
        public ActionResult<pokemon> Get(int id)
        {
            return "pokemon";
        }

        // POST api/pokemon
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/pokemon/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/pokemon/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
