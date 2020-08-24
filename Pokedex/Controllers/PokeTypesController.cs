using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;
// using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Pokedex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokeTypesController : ControllerBase
    {
        private PokedexContext _db;

        public PokeTypesController(PokedexContext db)
        {
          _db = db;
        }

        // GET api/poketype

        [HttpGet]
        public ActionResult<IEnumerable<PokeType>> Get()
        {
          var allInfo = _db.PokeTypes
          .Include(pokeType => pokeType.Pokemon);
          return allInfo.ToList();
        }

        // GET api/poketype/5
        [HttpGet("{id}")]
        public ActionResult<PokeType> Get(int id)
        {
          return _db.PokeTypes.FirstOrDefault(entry => entry.PokeTypeId == id);
        }
    }
}