using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pokedex.Models;
using Microsoft.EntityFrameworkCore;

namespace Pokedex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
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
        public ActionResult<Pokemon> Get(int id)
        {
            return _db.Pokemon.FirstOrDefault(entry => entry.PokemonId == id);        
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


        //Querying
        [HttpGet]
        public ActionResult<IEnumerable<Pokemon>> Get(string Species, string Description, double Weight, double Height, int Hp, int Attack, int Defense, int SpAtk, int SpDef, int Speed, string Ability)
        {
            var query = _db.Pokemon.AsQueryable();
            if(Species != null)
            {
                query = query.Where(entry => entry.Species == Species);
            }
            if(Description != null)
            {
                query = query.Where(entry => entry.Description == Description);
            }
            if(Weight != null)
            {
                query = query.Where(entry => entry.Weight == Weight);
            }
            if(Height != null)
            {
                query = query.Where(entry => entry.Height == Height);
            }
            if(Hp != null)
            {
                query = query.Where(entry => entry.Hp == Hp);
            }
            if(Attack != null)
            {
                query = query.Where(entry => entry.Attack == Attack);
            }
            if(Defense != null)
            {
                query = query.Where(entry => entry.Defense == Defense);
            }
            if(SpAtk != null)
            {
                query = query.Where(entry => entry.SpAtk == SpAtk);
            }
            if(SpDef != null)
            {
                query = query.Where(entry => entry.SpDef == SpDef);
            }
            if(Speed != null)
            {
                query = query.Where(entry => entry.Speed == Speed);
            }
            if(Ability != null)
            {
                query = query.Where(entry => entry.Ability == Ability);
            }
            return query.ToList();
        }

        //Pagination
        [HttpGet ("page")]
        public ActionResult<Pokemon> GetPage([FromQuery] UrlQuery urlQuery)
        {
            var valudUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
            var pagedData = _db.Pokemon
                .OrderBy(pokemon => pokemon.PokemonId)
                .Skip((valueUrlQuery.PageNumber-1) * validUrlQuery.PageSize)
                .Take(validUrlQuery.PageSize);
            return Ok(pagesData);
        }
    }
}
