using System;
using PokedexClient.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PokedexClient.Controllers
{
  public class PokeTypesController : Controller
  {
    public IActionResult Index()
    {
      List<PokeType> allPokeTypes = PokeType.GetPokeTypes();
      return View(allPokeTypes);
    }

    public IActionResult Details(int id)
    {
      PokeType pokeTypes = PokeType.GetDetails(id);
      return View(pokeTypes);
    }
  }
}