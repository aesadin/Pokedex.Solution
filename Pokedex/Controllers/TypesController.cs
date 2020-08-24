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
    public class TypesController : ControllerBase
    {
        private PokedexContext _db;

        public TypesController(PokedexContext db)
        {
          _db = db;
        }

        // GET api/type
        [HttpGet]
        public ActionResult<IEnumerable<Type>> Get()
        {
          return _db.Types.ToList();
        }

        // GET api/type/5
        [HttpGet("{id}")]
        public ActionResult<Type> Get(int id)
        {
          return _db.Types.FirstOrDefault(entry => entry.TypeId == id);
        }
    }
}