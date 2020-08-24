using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;

namespace Pokedex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private PokedexContext _db;

        public PokemonController(PokedexContext db)
        {
            _db = db;
        }

        // GET api/pokemon
        [HttpGet]
        public ActionResult<IEnumerable<Pokemon>> Get()
        {
            return _db.Pokemon.ToList();
        }

        // GET api/pokemon/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // // POST api/pokemon
        // [HttpPost]
        // public void Post([FromBody] string value)
        // {
        // }

        // // PUT api/pokemon/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // // DELETE api/pokemon/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}
