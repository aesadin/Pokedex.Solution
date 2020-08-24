using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
// using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;

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
          return _db.PokeTypes.ToList();
        }

        // GET api/poketype/5
        [HttpGet("{id}")]
        public ActionResult<PokeType> Get(int id)
        {
          return _db.PokeTypes.FirstOrDefault(entry => entry.PokeTypeId == id);
        }
    }
}