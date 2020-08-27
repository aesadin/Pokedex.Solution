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
        
        //I think this one needs to go the way of the bulbasaurs
        // GET api/pokemon
        // [HttpGet]
        // public ActionResult<IEnumerable<Pokemon>> Get()
        // {
        //     return _db.Pokemon.ToList();
        // }

        

        // GET api/pokemon/5
        [HttpGet("{id}")]
        public ActionResult<Pokemon> Get(int id)
        {
            return _db.Pokemon.FirstOrDefault(entry => entry.PokemonId == id);        
        }


        //Querying
        // GET api/pokemon
        // GET api/pokemon?q={Description: "The best pokemon"}
        [HttpGet]
        public ActionResult<IEnumerable<Pokemon>> Get(string Species, string PokeTypeName, string Description, double Weight, double Height, int Hp, int Attack, int Defense, int SpAtk, int SpDef, int Speed, string Ability)
        {
            var query = _db.Pokemon.AsQueryable();
            if(Species != null)
            {
                query = query.Where(entry => entry.Species == Species);
            }
            if(PokeTypeName != null)
            {
                query = query.Where(entry => entry.PokeTypeName == PokeTypeName);
            }
            if(Description != null)
            {
                query = query.Where(entry => entry.Description == Description);
            }
            if(Weight != 0)
            {
                query = query.Where(entry => entry.Weight == Weight);
            }
            if(Height != 0)
            {
                query = query.Where(entry => entry.Height == Height);
            }
            if(Hp != 0)
            {
                query = query.Where(entry => entry.Hp == Hp);
            }
            if(Attack != 0)
            {
                query = query.Where(entry => entry.Attack == Attack);
            }
            if(Defense != 0)
            {
                query = query.Where(entry => entry.Defense == Defense);
            }
            if(SpAtk != 0)
            {
                query = query.Where(entry => entry.SpAtk == SpAtk);
            }
            if(SpDef != 0)
            {
                query = query.Where(entry => entry.SpDef == SpDef);
            }
            if(Speed != 0)
            {
                query = query.Where(entry => entry.Speed == Speed);
            }
            if(Ability != null)
            {
                query = query.Where(entry => entry.Ability == Ability);
            }
            return query.ToList();
        }

        public ActionResult<Pokemon> GetPage([FromQuery] UrlQuery urlQuery)
        {
            var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
            var pagedData = _db.Pokemon
                .OrderBy(pokemon => pokemon.PokemonId)
                .Skip((validUrlQuery.PageNumber-1) * validUrlQuery.PageSize)
                .Take(validUrlQuery.PageSize);
            return Ok(pagedData);
        }
    }
}
