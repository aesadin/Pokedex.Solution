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

        // [HttpGet]
        // public ActionResult<IEnumerable<PokeType>> Get()
        // {
        //   var allInfo = _db.PokeTypes
        //   .Include(pokeType => pokeType.Pokemon);
        //   return allInfo.ToList();
        // }

        // GET api/poketype/5
        [HttpGet("{id}")]
        public ActionResult<PokeType> Get(int id)
        {
          var allInfo = _db.PokeTypes
          .Include(pokeType => pokeType.Pokemon)
          .FirstOrDefault(entry => entry.PokeTypeId == id);
          return allInfo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PokeType>> Get(string pokeTypeName)
        {
          var query = _db.PokeTypes.AsQueryable();
          if (pokeTypeName != null)
          {
            query = query.Where(entry => entry.PokeTypeName == pokeTypeName);
          }

          return query.ToList();
        }
    }
}