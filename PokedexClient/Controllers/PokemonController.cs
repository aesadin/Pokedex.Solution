using PokedexClient.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PokedexClient.Controllers
{
  public class PokemonController : Controller
  {
    public IActionResult Index()
    {
      var allPokemon = Pokemon.GetPokemons();
      return View(allPokemon);
    }

    public IActionResult Details(int id)
    {
      var pokemon = Pokemon.GetDetails(id);
      return View(pokemon);
    }
  }
}